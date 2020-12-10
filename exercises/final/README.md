# Save The Holidays From The Evil Snowmen
Take the holidays back from evil snowmen after they try to steal the holiday cheer.  

## Plan
Evil snowmen have stolen the holidays and it is up to you to save the town's cheer. The goal of this game is to find all of the things that were stolen and bring them back to the center of the town without losing your holiday cheer. The player will have to run around town and find all of the things that the snowmen stole from the houses. These objects are: 
* Presents
* Gingerbread Cookies
* Mittens
* Hot Chocolate
* Sled
* Ice Skates

 The player has a cheer meter that is shown at the top of the screen and everytime they get caught moving in the snowmen's shadows the cheer meter will go down. The evil snowmen are close to each of the objects and rotate with a shadow that the user has to avoid moving in. There is a fade in fade out so that the user gets more feedback that they were caught, besides just the meter. If the meter reaches zero, the game is over. There is text that shows the player how many items they have collected and how many more they need to collect.  


The player is able to pick the color of their sled at the beginning of the game. The player uses the arrow keys to move around town and collect the different items that were stolen. The objects have blue particles coming off of them so that they are easier to see. The camera is slightly behind the player and moves with them. The game takes place during the night so it is a little dark, with snow coming down. There are different houses and trees spread out throughout the town. There are roads that the player can move on while searching for the objects. The roads are set up so that they intersect with one another, but it is not too complicated. The objects will be scattered around the roads and houses, but have a blue particle effect on them so that the user can see them from far away. The user goes down the streets to try to find the objects. The entire game has an instrumental version of "Walking in a Winter Wonderland." The user has to make it back to the town hall, that is lit up in blue lighting. 


If the user's cheer meter reaches zero, the game over screen will play, and then the user is taken back to the title page. There is also a bonus round for users that win the game. The bonus round is a matching game where the users have to match the objects that they found during the first round. Animation is used with the cards to flip them when they are clicked. The color of the card also changes so that the user knows if it is selected or not. There is a button that users can press that will bring them back to the title screen if they do not want to play the matching game. 

### Game Screenshots
**Sled Selection:** 

![alt text](https://github.com/lh3006a/csc470-fall2020/blob/master/exercises/final/pickSled.png)
* This shows the sled selection, where users get to pick what color sled they want to play with. 

**View of Game:** 

![alt text](https://github.com/lh3006a/csc470-fall2020/blob/master/exercises/final/game.png)
* This is what is seen by the user during the game. The snowman has a shadow and rotates with the shadow. The snow can be seen falling. 

**Bonus Round:** 

![alt text](https://github.com/lh3006a/csc470-fall2020/blob/master/exercises/final/match.png)
* This shows the matching game. The squares change to a darker blue if they are selected and will turn around to show the object. If the two cards match, they will remain turned around and dark blue, but if they do not match, the cards will turn back to light blue and turn back around. 

### Game
I was able to get the shadows to move with the snowmen, and for the player to only lose cheer if they are moving in the shadow. If they are not moving in the shadow, the snowman does not recognize that the player is there. I decided not to have the user run around, but instead move around on a sled, that the user gets to pick out in the sled selection. There are a fair amount of houses that do not make the game too hard to navigate, but it does add some difficulty. Since I decided to have the character sitting on a sled instead of running, I did not animate the user. I decided to add the matching game as a bonus round because I wanted to work with animation, but still incorporate what the user had just done in the scene before. Animation is used to flip the cards to show the object, and to flip them around so that the object cannot be seen. I chose to use a particle effect on the objects so that they could better be seen by the user. I also lit up the town hall in blue so that the user could more easily find it when they had found all of the objects. I used a particle effect to make it look like it is snowing in the game. I wanted the game to look like it was taking place at night so I turned off the directional light, and used point lights to look like the light was coming from lamp posts. 




