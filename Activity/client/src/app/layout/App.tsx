import {Box, Container } from "@mui/material";
import axios from "axios";
import { useEffect, useState } from "react";
import NavBar from "./NavBar";
import Activitydashboard from "../../features/activities/activitydashboard";

function App() {
  const[activities, setActivities] = useState<Activity[]>([]);
  const[selectedActivity, setSelectedActivity] = useState<Activity | undefined>(undefined); 
  const[editMode, setEditMode] = useState(false);

  const HandleOpenform = (id?: string)=>{
      if(id) HandleSlectActivity(id);
      else CancelSelectActivity();
      setEditMode(true);
  }
  const HandleCloseform =()=>{
    setEditMode(false);
  }

  const HandleSlectActivity=(id:string)=>{
    setSelectedActivity(activities.find(x=>x.id===id));
    if(selectedActivity) setEditMode(false);
  }

  const CancelSelectActivity=()=>{
    setSelectedActivity(undefined);
    setEditMode(false);
  }

  
////....................Note: data fetching through fetch API...................
  // useEffect(() => {
  //   fetch("http://localhost:5133/api/Activity")
  //     .then(response => response.json())
  //     .then(data => setActivities(data))
  //     .catch(error => console.error("Error fetching activities:", error));
  // }, []);
//....................Note: data fetching through axios...................
  useEffect(()=>{
    axios.get<Activity[]>("http://localhost:5133/api/Activity")
      .then(response => setActivities(response.data))
      .catch(error => console.error("Error fetching activities:", error));
  },[])

  return (
    <Box sx={{backgroundColor:'#eaeaea'}}>
      <NavBar openForm = {HandleOpenform}/>
      <Container maxWidth="xl" sx={{mt:3}}>
        <Activitydashboard 
          activities={activities}
          selectActivity={HandleSlectActivity}
          CancelActivity={CancelSelectActivity}  
          selectedActivity={selectedActivity}
          editMode={editMode}
          openForm={HandleOpenform}
          closeForm={HandleCloseform}
          />
      </Container>
      
    </Box>
  )
}

export default App
