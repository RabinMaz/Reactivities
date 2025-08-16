import { List, ListItem, ListItemText, Typography } from "@mui/material";
import axios from "axios";
import { useEffect, useState } from "react";

function App() {
  const[activities, setActivities] = useState<Activity[]>([]);
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
    <>
      <Typography variant="h3">Activities</Typography>
      <List>
        {activities.map(activity => (
          <ListItem key={activity.id}>
            <ListItemText>{activity.title}</ListItemText>
          </ListItem>
        ))}
      </List>
    </>
  )
}

export default App
