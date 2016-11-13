VRArcTeleporter requires SteamVR so make sure it is imported into the project before importing
this package or there will be missing scripts in the prefab.

VR Arc Teleporter comes with everything you need to quickly get a locomotion system in your VR game.
Attach the ArcTeleporter script to the SteamVR_TrackedController object as is shown in the VRPlayerExample
prefab or in the example scene.

Now allows for fading transitions, custom control schemes, a rotatable room and fire a projectile and teleport
to it as an alternative to the arc.

The ArcTeleporter script can be overidden to give custom control over the controls and teleportation rules
or can be used standalone with the in built rule system (which I will expand upon soon).

Make sure you do the same things with both controllers individually, unless you want them to act differently.

Disable Pre Made Controls: (Generally leave unticked if your not a programmer)
The disable pre made controls just removes the part where listeners are added to the vive controller, this can be used if
you wanted to see the arc functionaliy but from another player in multiplayer, where the network would be telling the teleporter
what to do instead of the local controller.

Control Scheme:
Two Button Mode: The two button mode seperates out show the arc/firing the projectile and actually teleporting yourself,
because of this you can display the arc then decide not to teleport at all by releasing. In order to teleport you must be
holding down the show teleport button.
Press and Release: The press and release mode combines showing and teleporting into one button, in this mode holding down
the button will show the arc/fire the projectile and releasing will teleport, this has the benefit of freeing up a button
for your game but the downside of not letting you cancel a teleport one you hold down the button.

Transition:
Instance: Instant teleportation is just like it sounds the moment the teleport button is activated you will be moved to the new
spot.
Fade: The fade mode adds a slight delay during which a plane will be faded in then teleported and then faded out. You can set the
material the plane will use by placing your material in the Fade Material slot (the example uses a standard shader thats just black).
You can also set the fade duration which will determine the time it takes to fade in and out, the default being 0.5 seconds.
Dash: Dash moves the player area at a set speed (Dash Speed) toward the destination point, it can use a blur effect while transitioning
to help with possible motion sickness.

Firing Mode:
Arc:

Arc Implementation:
Fixed Arc: The fixed arc is good if there is little verticality in your level, it works well with the line renderer as
each line segment is equal distance so there are no stretched textures.
Physics Arc: The physics arc will allow you to point straight up and have the arc come right back down how you might
expect, the issue is each line segment will be different sizes so it is recommended to use the Color instead of a material
because there are some angle where part of the line will appear stretched.
You can test both out by changing the Arc Implementation variable on the script and see which works best for you. 

Arc Width: The width of the line renderer in unity units

Use Material:
Material: The material mode is best used with the fixed arc implementation and will allow you to use your own texture and
shader for the arc, the material used will switch between the good and bad spots depending on whether it's currently pointed
at a good spot or a bad spot.
The scale is used for making sure the texture is not stretched or squashed and the movement speed can be used to animated the
material (should use small numbers and this is affected by scale).
Colour: The colour can be used for a simpler look and will let you set the good and bad colours with alpha, Best used with the
physics implementation.

Teleport Cooldown:
You can add a cooldown here that will lock the ability to teleport for the given number of seconds, just set this to zero if you don't want
a cooldown. Just as advice it's important to communicate to the player that a cooldown is in effect so make sure to tie this into you UI in
some way if you intend to use a long cooldown.

Disable Room Rotation: This is if you are using the trackpad as your show teleport button and will disable the ability to rotate
the room when moving and holding down the trackpad.

Teleport and Room Highlight: The teleport highlight just like the room highlight can take an prefab, however the position and rotation
will be affected so if you want to replace them you should mirror them on the existing ones to get an idea of how they should be positioned
so the look right.

Only Land on Flat:
This will allow you to specify a slope limit in degrees, 0 will stop you from landing on anything, 90 will allow you to teleport onto
vertical walls and 180 is the same as having it toggled off.

Only land on tagged:
Ticking this will allow you to expand a list, you can set the size and type in the name of all the tags you want to whitelist. The tag
must be on the object with the collider to work. This will allow you to specify on the floor of a room can be teleported onto even though
you have a table with a collider.

Raycast layers:
Expanding raycast layers and adding to the size will allow you to enter the name of layers you either want the arc to go through or layers
you only want the arc to hit, you can change this by toggling the Ignore Raycast layers boolean, when unticked it will ignore anything on
the layers not specified and when ticked will only hit things on the layers specified. This is useful if you have invisible triggers in your
scene you want the arc to just go straight though. Remember that the object with the collider is the one that has to be set to the layer
in order to work.

Offset Transform:
You can click the create offset transform button to create and assign a new offset as a child of the controller.
The best way to place this is to start the game and pause when you can see the controller, move the transform
into the position you want then click the cog in the top right of the transform and click "Copy Component".
Stop the game and click the cog on the offset transform and click "Paste Component As Value".

Thanks for downloading.

Whats new!
1.1
-Dash mode (with optional blur toggle)
-New optional arc implementation (Fixed Arc and Physics Arc)
-Added offset transform
-Redone controller keys (seperated trackpad)
-Added optional teleporting cooldown timer
-Exapanded upon documentation
-Controller listeners are removed when the controller is disabled

1.0
-Added press and release to teleport as an alterative control scheme
-Added fade transition
-Projectile firing mode
-Can now rotate room with the trackpad
-Fixed bug where line would flicker red

0.5
-Fixed mistake with ExamplePlayer prefab in example scene

0.4
-Moved Editor script to an editor folder so the project can build.
-Added slope limit to land on flat for some leniency.
-Added tags list for limiting what can be teleported to based on tag.
-Added boolean to disable the premade controls.
-ArcTeleporter is now completely scaleable like the rest of the steamVR camera rig.

0.3
-Added layers. Make a list of layers you either only want to hit or that you want to ignore by toggle the Ignore Raycast Layers boolean

0.2
-Fixed issue where part of the line renderer would not disable when nothing was hit

0.1
-Initial release