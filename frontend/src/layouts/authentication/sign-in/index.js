/**
 =========================================================
 * Soft UI Dashboard React - v4.0.1
 =========================================================

 * Product Page: https://www.creative-tim.com/product/soft-ui-dashboard-react
 * Copyright 2023 Creative Tim (https://www.creative-tim.com)

 Coded by www.creative-tim.com

 =========================================================

 * The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
 */

import { useState } from "react";

// react-router-dom components
import {Link, useNavigate} from "react-router-dom";

// @mui material components
import Card from "@mui/material/Card";
import Switch from "@mui/material/Switch";
import Checkbox from "@mui/material/Checkbox";

// Soft UI Dashboard React components
import SoftBox from "components/SoftBox";
import SoftTypography from "components/SoftTypography";
import SoftInput from "components/SoftInput";
import SoftButton from "components/SoftButton";

// Authentication layout components
import BasicLayout from "layouts/authentication/components/BasicLayout";
import Socials from "layouts/authentication/components/Socials";
import Separator from "layouts/authentication/components/Separator";

// Images
import curved6 from "assets/images/curved-images/curved14.jpg";

async function login(email, password)
{
  try {
    const response = await fetch('http://localhost:5159/api/auth/login', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify({email, password}),
    });

    if(!response.ok){
      throw new Error('Login failed');
    }

    const data = await response.json();
    localStorage.setItem('token', data.token);
    return data;
  } catch(error) {
    console.error('Login error', error);
    throw error;
  }
}

function SignIn() {
  const [rememberMe, setRememberMe] = useState(true);
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');

  const navigate = useNavigate();

  const handleSetRememberMe = () => setRememberMe(!rememberMe);
  const handleSetEmail = (e) => setEmail(e.target.value);
  const handleSetPassword = (e) => setPassword(e.target.value);
  const handleLogin = async(e) =>{
    e.preventDefault();
    try {
    await login(email, password);
    navigate("/overview", {replace: true});
    } catch(error){
      console.log(error);
    }
  }

  return (
      <BasicLayout
          title="Preschool App. Welcome back!"
          description="Enter your email and password to sign in"
          image={curved6}
      >
        <Card>
          <SoftBox p={3} mb={1} textAlign="center">
            <SoftTypography variant="h5" fontWeight="medium">
              Sign-in with
            </SoftTypography>
          </SoftBox>
          <SoftBox mb={2}>
            <Socials />
          </SoftBox>
          <Separator />
          <SoftBox pt={2} pb={3} px={3}>
            <SoftBox component="form" role="form" onSubmit={handleLogin}>
              <SoftBox mb={2}>
                <SoftInput type="email" placeholder="Email" onChange={handleSetEmail}/>
              </SoftBox>
              <SoftBox mb={2}>
                <SoftInput type="password" placeholder="Password" onChange={handleSetPassword}/>
              </SoftBox>
              <SoftBox display="flex" alignItems="center">
                <Switch checked={rememberMe} onChange={handleSetRememberMe} />
                <SoftTypography
                    variant="button"
                    fontWeight="regular"
                    onClick={handleSetRememberMe}
                    sx={{ cursor: "pointer", userSelect: "none" }}
                >
                  &nbsp;&nbsp;Remember me&nbsp;
                </SoftTypography>
              </SoftBox>
              <SoftBox mt={4} mb={1}>
                <SoftButton variant="gradient" color="primary" fullWidth type="submit">
                  sign up
                </SoftButton>
              </SoftBox>
              <SoftBox mt={3} textAlign="center">
                <SoftTypography variant="button" color="text" fontWeight="regular">
                  Don&apos;t have an account?{" "}
<SoftTypography
    component={Link}
    to="/authentication/sign-up"
    variant="button"
    color="dark"
    fontWeight="bold"
    textGradient
>
  Sign up
</SoftTypography>
                </SoftTypography>
              </SoftBox>
            </SoftBox>
          </SoftBox>
        </Card>
      </BasicLayout>
  );
}

export default SignIn;
