import styles from "./card.module.css";

const card = {
   id: 1,
   title: 'Card',
   description: 'A card component.',
   viagemURL: "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.civitatis.com%2Fblog%2Fpt-br%2Fmelhores-praias-rio-de-janeiro%2F&psig=AOvVaw09L_nQp_a_drZAtSYGtrsp&ust=1705026566057000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCKiV04ml1IMDFQAAAAAdAAAAABAD"


}



export default async function Card () {
   
   //const cards = await fetch('http://localhost:5108/api/Agencia').then(res => res.json())
   //console.log(cards);

return(
   <div className={styles.container}>
      <div className={styles.card}>
         <img src={viagemURL} alt={card.title}/>
         <div className={styles.card_title}>
            <h2>{card.title}</h2>

         
         </div>
      </div>

   </div>


)



}