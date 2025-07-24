# testplanets

Unity Version 2021.3.45f1

## Including Cubemap files for the Skybox
This project uses the ["Real Stars Skybox Lite"](https://assetstore.unity.com/packages/3d/environments/sci-fi/real-stars-skybox-lite-116333#content) package from the Unity Asset Store.
The .cubemap files in this asset are too large for GitHub, so you will need download and update the package locally.

## Streaming Output via NDI
To view the full dome output outside of Unity and in full screen, you will need to install [NDI Tools](https://ndi.video/tools/) and use the NDI Video Monitor or Studio Monitor.

## Connecting to Android AR OSC Sender
The Android app file is linked here - [FulldomeSenderAR.apk](https://o365coloradoedu-my.sharepoint.com/:u:/g/personal/riva3436_colorado_edu/EWAa1u6-1hhNmxxI1E4OqskBw9ZZKoCDaHzqrozyEiQLHA?e=9KGpp9)
### Workflow
- Install the app on an Android Device
- Ensure that both the Android Device and the computer running this Unity project are on the same local network
- Note down the local IP address of the computer
- In the app, enter the computer's IP address in the text box at the top of the screen, and press Connect OSC
- After this, the "Place" toggle can be used to activate or deactivate the ability to place the origin cube for tracking at the center of the planetarium space.
- The "OSC" toggle can be used to start or stop sending OSC messages from the phone to the computer
