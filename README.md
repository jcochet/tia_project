# Projet TIA
ABABOU Sarah & COCHET Julien - M2 Info IL
# Table des matières
1. [Conception et fonctionnalités envisagées](#design)
    1. [Écran de jeu](#gamescreen)
    2. [Édition du terrain](#fieldeditor)
2. [Fonctionnalités implémentées](#features)
    1. [Terrain de jeu virtuel](#playground)
    3. [Manipulation d'objets virtuels](#manipulation)
    3. [Mode facile](#easy)
    4. [Objet relié à une carte AR](#armarker)
    5. [Interaction avec un objet réel](#real)
    6. [GUI affichant l'état du jeu](#gui)
    7. [Informations affichées une fois le jeu fini](#finished)
    8. [Application Android](#android)
3. [Manuel d'utilisation](#manual)
4. [Projet Unity](#unity)
## Conception et fonctionnalités envisagées <a name="design"></a>
Le sujet nous proposait de créer un jeu parmis deux options : une course d'obstacle ou une machine de Rube Goldberg. Avec l'aval du professeur, nous avons finalement décidé de créer notre propore jeu : un **jeu de tir à l'arc**.

Nous avons réfléchis aux fonctionnalités à implémenter et avons dessiner les différentes interfaces associées. Celles-ci étaient au nombre de deux, nous les détaillons ci-dessous.
### Écran de jeu <a name="gamescreen"></a>
<img src="https://github.com/jcochet/tia_project/blob/main/img/concept_sketch_0.jpg" alt="concept_sketch_0.jpg" width="50%">
On trouvait ici l'écran où se déroule le jeu. Le but étant de tirer sur une cible virtuelle attachée à une carte AR. Toucher la cible augmentait le score du joueur et viser à côté faisait planter la flèche dans le sol. Un viseur au centre de l'écran (désactivé en mode difficile) permetterait au joueur de savoir s'il toucherait ou non la cible. La puissance du tir aurait été ajustable en appuyant plus ou moins longtemps sur l'écran. Les boutons en bas de l'écran auraient permis de basculer sur l'édition de terrain ou de mettre le jeu en pause.

### Édition du terrain <a name="fieldeditor"></a>
<img src="https://github.com/jcochet/tia_project/blob/main/img/concept_sketch_1.jpg" alt="concept_sketch_1.jpg" width="50%">
Sur l'édition du terrain, il n'aurait pas été possible de tirer, mais des éléments de décor (arbres, murs, etc.) auraient été plaçables, déplaçables et supprimables. Il aurait aussi été possible de retourner à l'écran de jeu.

## Fonctionnalités implémentées <a name="features"></a>
Dans cette section, nous allons revenir sur ce qui a été effectivement implémenté, en reprenant les huits points demandés par le sujet.
### Terrain de jeu virtuel <a name="playground"></a>
<img src="https://github.com/jcochet/tia_project/blob/main/img/virtual_playground.jpg" alt="virtual_playground.jpg" width="50%">
En posant la carte "Drone", trois cubes apparaisent, ceux-ci font office de terrain de jeu virtuel.

### Manipulation d'objets virtuels <a name="manipulation"></a>
<img src="https://github.com/jcochet/tia_project/blob/main/img/virtual_objects_manipulation.gif" alt="virtual_objects_manipulation.gif" width="50%">
S'il n'y pas de partie démarrée, les trois cubes précédement évoqués sont déplaçables en un simple drag & drop sur l'écran du téléphone.

### Mode facile <a name="easy"></a>
<img src="https://github.com/jcochet/tia_project/blob/main/img/easy_mode.gif" alt="easy_mode.gif" width="50%">
Au cours d'une partie, un viseur au centre de l'écran permet de voir si la cible sera atteinte ou non. Ce viseur peut être désactivé en enclenchant le mode difficile, en cliquant sur le bouton en haut à gauche.

### Objet relié à une carte AR <a name="armarker"></a>
<img src="https://github.com/jcochet/tia_project/blob/main/img/object_controlled_by_ar_marker.jpg" alt="object_controlled_by_ar_marker.jpg" width="50%">
En posant la carte "Astronaut", une cible apparait. Celle-ci ne peut pas être déplacée au sein du jeu, elle sera toujours juste au dessus de la carte.

### Interaction avec un objet réel <a name="real"></a>
<img src="https://github.com/jcochet/tia_project/blob/main/img/real_object_interaction.gif" alt="real_object_interaction.gif" width="50%">
Les flèches tirées par le joueur peuvent se planter dans la surface où est posé la carte "Drone".

### GUI affichant l'état du jeu <a name="gui"></a>
<img src="https://github.com/jcochet/tia_project/blob/main/img/2d_gui.jpg" alt="2d_gui.jpg" width="50%">
L'application démarre sur un écran ayant un bouton "Start" pour commencer le jeu. Il n'y a que sur cet écran que les cubes peuvent être déplacés.

### Informations affichées une fois le jeu fini <a name="finished"></a>
<img src="https://github.com/jcochet/tia_project/blob/main/img/game_finished.jpg" alt="game_finished.jpg" width="50%">
Lorqu'une partie est finie, le score du joueur est affiché.

### Application Android <a name="android"></a>
L'entièreté du jeu est disponible sous le forme d'un apk. Celui-ci est disponible dans les [releases de ce git](https://github.com/jcochet/tia_project/releases).
## Manuel d'utilisation <a name="manual"></a>
* Lancer l'application et mettre en place une **carte "Astronaut"** et une **carte "Drone"**. Vous pouvez déplacer les cubes si vous le souhaitez.
* Lancer le jeu en appuyant sur le **bouton "Start"**. Vous disposer de 30 secondes pour faire le meilleur score possible. Vous marquez 100 points à chaque fois que vous touchez la cible avec une flèche. **Pour tirer, touchez n'importe quel partie de l'écran.** Le viseur est désactivable en décochant la case "Easy Mode".
* Au bout des 30 secondes, la partie est terminée et votre score s'affiche. Vous pouvez relancer une partie en cliquant sur le bouton "Start".

Vous trouverez ci-dessous une vidéo montrant le déroulement du jeu :

https://user-images.githubusercontent.com/45289115/155973114-44a11ab3-ec08-40f4-8fcb-811b9a60813b.mp4

### Projet Unity <a name="unity"></a>
Le projet utilise la version 2020.3.30f1 de Unity.
Les packages utilisés sont :
* Vuforia Engine AR - Version 10.5.5
* JetBrains Rider Editor - Version 2.0.7
* Test Framework - Version 1.1.31
* TextMeshPro - Version 3.0.6
* Timeline - Version 1.4.8
* Unity UI - Version 1.0.0
* Version Control - Version 1.15.13
* Visual Studio Code Editor - Version 1.2.5
* Visual Studio Editor 2.0.14
