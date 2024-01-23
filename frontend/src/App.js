import LoginPage from "./pages/LoginPage";
import { ThemeProvider } from "@mui/material";
import { appTheme } from "./theme";

const App = () => {
  return (
    <ThemeProvider theme={appTheme}>
      <LoginPage />
    </ThemeProvider>
  );
};

export default App;
