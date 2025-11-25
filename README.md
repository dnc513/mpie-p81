# Practical 8.1: Lighting a Haunted House

In the last lecture, you learned some techniques for simulating realistic lighting in Interactive Environments and how to implement them in Unity. In this practical, you are going to use these techniques to implement the lighting for a horror scene.

By the end of this practical you will be able to:

- Change the ambient light in a scene by choosing a different skybox
- Add lights to a scene and manipulate their parameters 
- Position lights using transforms
- Create shiny objects by manipulating materials
- Create reflections using Reflection Probes
- Manipulate the parameters of lights from scripts

To get started, create a git repository in your account based on this template and clone it onto your machine.

The Unity project in the repo contains a scene from an interactive horror movie, in which the viewer finds an abandoned house in the woods. As it stands, the scene and the house it contains don’t really have the aesthetic of a horror movie (i.e. dark and scary)! In this practical class, you will fix this using a range of different lighting techniques.

## Task 1: Using a Different Skybox to Change Day into Night
In the lecture, you saw how Unity could be configured to use a skybox as its ambient light source. At the moment, the scene’s skybox shows a bright sunny day, which isn’t really right for a horror scene. Your first task is to change the scene’s skybox to one that shows a dark and moonlit night.

You can use the ‘NightSkyBox’ material, found in the ‘PracticalAssets/Materials’ folder, to do this. You can change the scene’s skybox in the project’s lighting settings, which are found in the menu under ‘Windows > Rendering > Lighting’.

To complete the task, you should reorient the Directional Light in the scene so that it is aligned with the moon. This will mean that moonlight is cast across your scene in a direction that’s consistent with the position of the moon in the Skybox. You should also change the colour of the directional light, so it has a slight blue tint. One quick and effective way to do this would be to use the pipette tool and click on the moon in the skybox.

## Task 2: Lighting Inside the House
If you walk into the house, you’ll notice that you can’t see much. This is because there aren’t any light sources inside, and the ambient and direction lights are blocked by the house’s shadow map. 

In this task, you should allow the user to explore the house by adding appropriate lighting inside. When lighting the house, you should position your lights near to the candles, so that it appears that the room is being illuminated by candlelight. You should also add a light source that makes the cauldron glow green. When creating your lights, remember to enable shadow maps.

Complete the task by enabling diffuse reflections on all objects that don’t move within the house, using Unity’s pre-computed GI approach.

## Task 3: Adding a Flashlight
In this task, you should add a flashlight (i.e. a torch) to the ‘FPSController’ game object. This flashlight should be turned on and off by pressing the ‘F’ key on the keyboard. Tip: recalling what you were taught about transforms and coordinate systems should help you implement the flashlight more easily.

You may notice that some of the lights that you set up previously disappear when your flashlight is turned on. This is the result of Unity trying to increase rendering efficiency. You can turn off this automatic optimization, and make all the lights appear at once, by setting each light’s ‘Render Mode’ to ‘Important’ rather than ‘Auto’.

## Task 4: Shiny Candle Holders
Manipulate the ‘Smoothness’ and ‘Metallic’ material parameters of the ‘CandleStand’ material (found in the ‘PracticalAssets/Materials’ folder) to make the candle-holders shiny. Additionally, explore how to use a reflection probe to make the surface of the candle-holders show a reflection of the room (note: the effect will only be very slight due to their small size). 

## Task 5: Flickering Candles and Sheet Lightening
Using a combination of light sources and accompanying scripts, add the following effects to your scene:

- A flickering effect in the candle-lights
- Bright sheet lightening, which illuminates the scene periodically

When implementing the flickering candles, you may wish to use the PerlinNoise method to create a realistic looking effect (see http://docs.unity3d.com/ScriptReference/Mathf.PerlinNoise.html).

## Optional Extensions
If you complete all of the above tasks before the end of the practical, or would like to continue to develop your skills in your free study time, then you should consider attempting the following tasks:

- Explore the use of particle systems to create candle flames and a fire under the cauldron (see http://glennmurphy.weebly.com/fire-particle-tutorial.html).
- Investigate how to use normal maps to add additional detail to the surfaces of the house and the props inside it (see http://docs.unity3d.com/500/Documentation/Manual/HOWTO-bumpmap.html).
- If you happen to have a very fancy graphics card you could try out Unity’s new HDRP to get real time ray tracing. WARNING: do not use this in your projects, as it will likely mean that the marker cannot mark your work: https://docs.unity3d.com/Packages/com.unity.render-pipelines.high-definition@7.1/manual/Ray-Tracing-Getting-Started.html 
