import styled from "styled-components";
import { Button, TextField } from "@mui/material";
import Logo from "../../assets/logo Preschool.png";

const Wrapper = styled.div`
  width: 95vw;
  height: 90vh;
  display: flex;
  justify-content: flex-end;
  align-items: center;
  background-color: #ecc225;
  border-radius: 30px;
`;

const LoginComponent = styled.div`
  width: 50%;
  height: 99.7%;
  display: flex;
  justify-content: space-evenly;
  align-items: center;
  border-radius: 29px;
  background-color: white;
  border: 1px solid #ecc225;
  flex-direction: column;
  gap: 10px;
`;

const InputWrapper = styled.div`
  width: 40%;
  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;
  gap: 10px;
`;

const StyledTextField = styled(TextField)`
  width: 100%;
`;

const StyledButton = styled(Button)`
  width: 100%;
  background-color: #ecc225;
`;

const LoginPage = () => (
  <Wrapper>
    <LoginComponent>
      <img src={Logo} alt="logo" />
      <InputWrapper>
        <StyledTextField
          id="outlined-required"
          label="Email address"
          defaultValue="john@doe.com"
        />
        <StyledTextField
          id="outlined-required"
          label="Password"
          defaultValue="password"
          type={"password"}
        />
        <StyledButton variant="contained">Sign in</StyledButton>
      </InputWrapper>
    </LoginComponent>
  </Wrapper>
);

export default LoginPage;
