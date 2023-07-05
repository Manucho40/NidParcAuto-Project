import { FC } from "react";

type Props = {
    popupAction:  ()=> void;
}
 
const Button: FC <Props> = ({popupAction}) => {


    return ( 
        <>
            <button className="btn btn-secondary" onClick={popupAction}>Ajouter</button>
        </>
     );
}
 
export default Button;