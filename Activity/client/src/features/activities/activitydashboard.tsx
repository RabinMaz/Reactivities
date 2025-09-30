import { Grid } from '@mui/material'
// import { List, ListItem, ListItemText } from "@mui/material";
import ActivityList from './activityList';
import ActivityDetails from '../Details/activityDetails';
import ActivityForm from '../form/activityForm';


type activityType = {
    activities:Activity[];
    selectActivity: (id:string)=>void;
    CancelActivity:()=>void;
    selectedActivity:Activity | undefined;
    openForm: (id :string)=>void;
    closeForm: ()=>void;
    editMode: boolean;
}
    
const Activitydashboard = ({activities,
                            selectActivity,
                            CancelActivity,
                            selectedActivity,
                            openForm,
                            closeForm,
                            editMode }:activityType) => {
  return (
    <Grid container spacing={3}>
        <Grid size={7}>
            {/* <List>
                   {activities.activities.map((activity) => (
                    <ListItem key={activity.id}>  
                    <ListItemText>{activity.title}</ListItemText>
                    </ListItem>
                ))}  
            </List> */}
            <ActivityList 
                activities={activities}
                selectActivity={selectActivity}
                
            />
        </Grid>
            <Grid size={5}>
            {/* Right side */}
            {/* {activities[0] && <ActivityDetails activity={activities[0]}/>} */}
            {selectedActivity && !editMode && 
                <ActivityDetails 
                    activity={selectedActivity} 
                    CancelActivity={CancelActivity}
                    openForm={openForm}/>}

            {editMode && <ActivityForm
                             closeForm={closeForm}
                              activity={selectedActivity}
                              Header={selectedActivity ? 'Edit Activity' : 'Create Activity'}
                           />}
         </Grid> 
  
     </Grid>   
  )
}

export default Activitydashboard