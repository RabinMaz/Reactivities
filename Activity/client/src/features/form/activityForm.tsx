import { Box, Button, Paper, TextField, Typography } from "@mui/material";
type ActivityFormProps = {
    closeForm: ()=>void; 
    activity?: Activity;
    Header:string
}
const ActivityForm = ({closeForm,activity,Header}:ActivityFormProps) => {
  return (
    <Paper sx={{p:2, borderRadius:3}}>
      <Typography variant="h5" gutterBottom color="primary">
        {Header}
      </Typography>
      <Box component="form" sx={{display:'flex', flexDirection:'column', gap:2}}>
        <TextField value = {activity?.title}  label="Title" fullWidth/>
        <TextField value={activity?.description} label="Description" multiline rows={3}/>
        <TextField value={activity?.category} label="Categpry" fullWidth/>
        <TextField value= {activity?.date} type="Date"/>
        <TextField value={activity?.city} label="City" />
        <TextField value={activity?.venue} label="Venu" />
      </Box>
      <Box sx={{display:'flex', justifyContent:'end', gap:4, mt:2}}>
        <Button variant="contained" color="success">Submit</Button>
        <Button variant="contained" color="inherit" onClick={closeForm}>Cancel</Button>
      </Box>
    </Paper>
  )
};

export default ActivityForm;
