import { Button, Card, CardActions, CardContent, CardMedia, Typography } from "@mui/material";

type ActivityDetail = {
    activity: Activity;
    CancelActivity:()=>void;
    openForm: (id :string)=>void;
}

const ActivityDetails = ({activity,
                          CancelActivity,
                          openForm}:ActivityDetail) => {
  return ( 
    <Card sx={{borderRadius:3, p:2}}>
         <CardMedia
         component='img'
         src={`/images/categoryImages/${activity.category}.jpg`}
         />   
        <CardContent>
            <Typography variant="h5">{activity.title}</Typography>
            <Typography variant="subtitle1">{activity.date}</Typography>
            <Typography variant="body1">{activity.description}</Typography>
        </CardContent>
        <CardActions>
            <Button color="primary" onClick={()=>openForm(activity.id)}>Edit</Button>
            <Button color="inherit" onClick={CancelActivity}>Cancel</Button>
        </CardActions>
    </Card>


  )
};

export default ActivityDetails;
