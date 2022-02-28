# Projet TIA
ABABOU Sarah & COCHET Julien - M2 Info IL
## Conception et fonctionnalités envisagées
Le sujet nous proposait de créer un jeu parmis deux options : une course d'obstacle ou une machine de Rube Goldberg. Avec l'aval du professeur, nous avons finalement décidé de créer notre propore jeu : un **jeu de tir à l'arc**.
Nous avons réfléchis aux fonctionnalités à implémenter et avons dessiner les différentes interfaces associées. Celles-ci étaient au nombre de deux, et nous avons les détailler ci-dessous.
### Écran de jeu
![concept_sketch_0.jpg](https://github.com/jcochet/tia_project/blob/main/img/concept_sketch_0.jpg)
On trouvait ici l'écran où se déroule le jeu. Le but étant de tirer sur une cible virtuelle attachée à une carte AR. Toucher la cible augmentait le score du joueur et viser à côté faisait planter la flèche dans le sol. Un viseur au centre de l'écran (désactivé en mode difficile) permetterait au joueur de savoir s'il toucherait ou non la cible. La puissance du tir serait ajustable en appuiyant plus ou moins longtemps sur l'écran. Les boutons en bas de l'écran aura permis de basculer sur l'édition de terrain ou de mettre le jeu en pause.
### Édition du terrain
![concept_sketch_1.jpg](https://github.com/jcochet/tia_project/blob/main/img/concept_sketch_1.jpg)
Sur l'édition du terrain il n'aurait pas été possible de tirer, mais des éléments de décor (arbres, murs, etc.) auraient été plaçables, déplaçables et supprimables. Il aurait aussi été possible de retourner à l'créan de jeu.
## Fonctionnalités implémentées
Dans cette section, nous allons revenir sur ce qui a été effectivement implémenté, en reprenant les huits points demandés par le sujet.
### Terrain de jeu virtuel
![virtual_playground.jpg](https://github.com/jcochet/tia_project/blob/main/img/virtual_playground.jpg)
En posant la carte "Drone", trois cubes apparaisent, ceux-ci font office de terrain de jeu virtuel.
### Manipulation d'objets virtuels
![virtual_objects_manipulation.gif](https://github.com/jcochet/tia_project/blob/main/img/virtual_objects_manipulation.gif)
S'il n'y pas de partie démarrée, les trois cubes précédement évoqués sont déplaçables en un simple drag & drop sur l'écran du téléphone.
### Mode facile
![easy_mode.gif](https://github.com/jcochet/tia_project/blob/main/img/easy_mode.gif)
Au cours d'une partie, un viseur au centre de l'écran permet de voir si la cible sera atteinte ou non. Ce viseur peut être désactivé en enclenchant le mode difficile, en cliquant sur le bouton en haut à gauche.
### Objet relié à une carte AR
![object_controlled_by_ar_marker.jpg](https://github.com/jcochet/tia_project/blob/main/img/object_controlled_by_ar_marker.jpg)
En posant la carte "Astronaut", une cible apparait. Celle-ci ne peut pas être déplacée au sein du jeu, elle sera toujours juste au dessus de la carte.
### Interaction avec un objet réel
![real_object_interaction.gif](https://github.com/jcochet/tia_project/blob/main/img/real_object_interaction.gif)
Les flèches tirées par le joueur peuvent se planter dans la surface où est posé la carte "Drone".
### GUI affichant l'état du jeu
![2d_gui.jpg](https://github.com/jcochet/tia_project/blob/main/img/2d_gui.jpg)
L'application démarre sur un écran ayant un bouton "Start" pour commencer le jeu. Il n'y a que sur cet écran que les cubes peuvent être déplacés.
### Informations affichées une fois le jeu fini
![game_finished.jpg](https://github.com/jcochet/tia_project/blob/main/img/game_finished.jpg)
Lorqu'une partie est finie, le score du joueur est affiché.
### Tout sur une seule application Android
L'entièreté du jeu est disponible sous le forme d'un apk. Celui-ci est disponible dans les [releases de ce git](https://github.com/jcochet/tia_project/releases).
