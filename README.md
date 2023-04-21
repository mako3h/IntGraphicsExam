# Intermediate Graphics Final Exam<br>
<br>

# Pre-Exam Incorporated<br>
<br>
All of the things that I added before the exam began are in a folder named "ExamSetup".  It is very organized with three folder within that (Materials, Shaders and Assets). I have a scene named "PreExam" that visually shows what I added. The actual exam pracical will be made within a scene named "Exam". <br>
Colin was asked within the discord if this was fine and he believes it was fine as we were allowed to do it within the midterm. I am communicating each thing I added into the unity project below. <br>
<br>

**Shaders Implemented:**<br>
* Bloom (This was the bloom shader implemented from the lecture. I editted this so that there is a "blur" variable)<br>
* Depth of Field (This shader was made from the lecture)<br>
* LUT (This is the LUT shader that was made in the lecture. I have the neutral LUT asset png that was given to us in class too)<br>
* Color Shadow (This was a color shadow shader that we were given in a tutorial)<br>
* Lined Shadow (We made this in a tutorial. We had to edit the colored shadow (one above) to work as a line shadow)<br>
* Glass (This shader was made/given in a lecture)<br>
* Decals (This shader was made within a lecture)<br>
* ToonRamp (This shader was given to us during a lecture. THis shader is editted so that there is rim lighting and bump maps)<br>
* Water (This is the main water shader we made in class. I added the foam shader qualities so that this implemented shader works like normal but has foam and bump)<br>
* Outline (This was the shader that we made in class. This shader is editted so that there is also rim lighting and toon ramps attached)<br>
* Normal Map (This is the normal map shader made in class. This is editted to have bump added along with being able to change to colour of the texture)<br>
<br>

**C# Scripts Implemented:**<br>
* Bloom (The one we made within class to attach to the camera)<br>
* Depth of Field (The one we made within class to attach to the camera)<br>
* Screen Camera Shader (I made this within the first assignment to ensure that the lut is able to work. It is attached onto the camera)<br>
* Decals (This was created in a lecture to allow the decals shader to be toggled on/off)<br>
<br>

**Materials Made (I am just going to put points down instead of explaining each):**<br>
* Colored Shadow Material<br>
* Glass Material<br>
* LUT Material<br>
* Normal Map Material<br>
* ToonRamp Material<br>
* Outline Material<br>
* Water Wave Material<br>
<br>

**Assets Implemented:**<br>
(All normal maps were made using this website https://cpetry.github.io/NormalMap-Online/)<br>
* Grass Texture (Made myself)<br>
* Grass Normal Map (Made using the website)<br>
* Glass Texture (Made myself)<br>
* Glass Normal Map (Made using the website)<br>
* Ice Texture (Made myself)<br>
* Ice Normal Map (Made using the website)<br>
* Water Texture (Was given to us in a lecture)<br>
* Water Foam (Was given to us in a lecture)<br>
* Water Normal Map (Was given to us in a lecture)<br>
* 3D Modelled Monkey .obj (This was taken from blender as it is one of their prefabs. I am only using this within the PreExam Scene where I have all of this stored. Does nothing for the porject other than helping me visually articulate what I have within the unity file)<br>
* Two Ramp Textures (One is white to blue. The other is Black to white. Both made by myself)<br>
* Neutral LUT (This was given in a lecture. Acts as a base for making custom LUT's)<br>
* Shadow Lines Texture (Given to me in a tutorial where we had to make lined shadows)<br>
<br>
I DID NOT WORK ON ANYTHING FOR THE EXAM. THIS WAS SIMPLY TO BE ORGANIZED SO THAT ONCE THE EXAM BEGINS, I CAN FOCUS ON SOLELY APPLYING MY SKILLS.<br>
<br>
<br>
<br>

# Final Exam <br>

**Part 1:**<br>
So first off, I am an odd numbered student so I created a scene for the purple/pinkish tunnel scene with the ninja turtle surfing. I began by adding planes and walls around the scene. Then I made materials with bland colours like pink, purple, etc, that I would then be able to just put on these walls, object, etc, that will not be needing a shader implemented to it. I created a player for the scene using cubes in the unity editor. I made a prefab of it in case you are in awe of how amazing my ninja turtle is haha. <br>

**Moving Light:**<br>
I created an area light so that there was light a over head lamp that showed the scene. To make this light move, I created a c# script where once attached, it would continousily rotate around a midpoint that I set it to. This allowed for that effect of a moving light. 

**NormalMapping:**<br>
For normal mapping, the only thing that I had to apply it to was the brick wall in the back of the scene. I added bump mapping to this to ensure the wall had this bumpy, brick wall feel to it as it should. I retrieved this brick wall asset online from this website (https://www.alldesigncreative.com/3d-textures/wall-texture-bricks/). I then used this website to make a normal map of it (https://cpetry.github.io/NormalMap-Online/). <br>

**Water:**<br>
I began by created three new textures. I used this website named pixlr (https://pixlr.com/e/#editor), to draw out a new water texture. Then I made a mud texture on the same platform. I then used this website (https://cpetry.github.io/NormalMap-Online/) to then make a normal map of this new water texture I made. I used the water shader that was made within class, but I modified it so that the shader also holds the properties of the foam shader we made in class. Once I combined these two shaders, I found it provided the player with a more enhanced water matieral. Within the scene, I made it so that there were two different planes, each one holding the same water shader, but different materials. This is because for the original water material, I made it so that there was not really any up and down movement of the waves. This ensured that it look flatter and it then resembled the given gif much more. To have this mud effect, I decided to make this second plane using the water shader but adding the mud texture to it. I placed this plane slightly under the water wave and I increased the value of the up and down movement value of the mud wave. This ensured that the tiptop of the highest wave would peek right over top of the original water wave slightly and show this mud texture making it look like sometimes mud flows down the river. Then by changing the speed, I made it look more realistic. <br>

**Bloom:**<br>
This is the same bloom shader that was made within a lecture of ours. Same as the bloom c# script. Although they are pretty much the same, I editted the shader so that there is a blurSize variable where you can change it in the unity inspector and the pixels on screen will slowly be blurred. I attached this to the camera to create this effect of the bloom within the scene. After lots of time trying to code one, I was unsure and unable to create a script that would toggle on/off the bloom. Therefore it is currently always on. <br>

**End:**<br>
Everything I used within this exam is in a folder named exam and all organized within unity. There is a release named "Build" which holds the needed things to run the final build of the unity project. 