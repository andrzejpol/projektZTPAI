import { createTheme } from "@mui/material";

export const appTheme = createTheme({
  components: {
    MuiButton: {
      variants: [
        {
          props: { variant: "contained" },
          style: {
            textTransform: "none",
            background: "#ecc225",
            "&:hover": {
              background: "#face2b",
            },
          },
        },
      ],
    },
  },
});
