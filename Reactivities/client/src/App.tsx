import { List, ListItem, ListItemText, Typography } from "@mui/material"
import axios from "axios"
import { useEffect, useState } from "react"

function App() {
  const[activities, setactivities] = useState<Activity[]>([])
useEffect(() => {
    // fetch("http://localhost:5081/api/activities")
    //   .then((response) => response.json())
    //   .then((data) => {
    //     setactivities(data)
    //   })
     axios.get<Activity[]>("http://localhost:5081/api/activities")
     .then((response)=>{setactivities(response.data)})

      .catch((error) => {
        console.error("Error fetching activities:", error)
      })
  }, [])

  return (
    <>
      {/* <h3 className="app" style={{color:"red"}}>Reactivities</h3> */}
      <Typography variant="h3">Reactivities</Typography>
      <List>
        {activities.map((activity) => (
          <ListItem key={activity.id}>
           <ListItemText> {activity.title}</ListItemText>
          </ListItem>
        ))}
      </List>
    </>
  )
}

export default App
