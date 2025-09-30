import { Group } from "@mui/icons-material";
import { AppBar, Box , Toolbar , Typography, Container, MenuItem, Button } from "@mui/material";

type NavBarProps = {
  openForm: (id?:string)=>void;
}

const NavBar = ({openForm}:NavBarProps) => {
  return (
        <Box sx={{ flexGrow: 1 }}>
            <AppBar position="static" sx={{backgroundImage: 'linear-gradient(135deg, #182a73 0%,#218aae 69%,#20a7ac 89%)'}}>
                <Container maxWidth="xl">
                    <Toolbar sx={{display:"flex", justifyContent:"space-between"}} >
                        <Box>
                            <MenuItem sx={{display:"flex", gap:2}}>
                               <Group fontSize="large"/>
                               <Typography variant="h4" fontWeight='bold'>
                                  Reactivities
                                </Typography>
                            </MenuItem>
                        </Box>
                        <Box sx={{display:"flex"}}>
                            <MenuItem sx={{fontSize:'1.2rem', fontWeight:'bold', textTransform:'Uppercase'}}>
                               Activity List
                            </MenuItem>
                            <MenuItem sx={{fontSize:'1.2rem', fontWeight:'bold', textTransform:'Uppercase'}}>
                               About
                            </MenuItem>
                            <MenuItem sx={{fontSize:'1.2rem', fontWeight:'bold', textTransform:'Uppercase'}}>
                               Contained
                            </MenuItem>
                        </Box>
                        <Button size="medium" variant="contained" color="warning" onClick={()=>openForm()}>Create Activity</Button>
                    </Toolbar>
                    
                </Container>
            </AppBar>
        </Box>
   )
};

export default NavBar;
