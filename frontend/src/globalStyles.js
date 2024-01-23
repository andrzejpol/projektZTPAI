import {createGlobalStyle} from "styled-components";
import '@fontsource/roboto/400.css';

const GlobalStyle = createGlobalStyle`
  body {
    margin: 0;
    padding: 0;
    min-height: 100vh;
    box-sizing: border-box;
    display: flex;
    justify-content: center;
    align-items: center;

  }
`;

export default GlobalStyle;