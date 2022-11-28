### BlacFacs ###
## Georgia Institute of Technology 2022-2023 Junior Design Project ##
## Team JDF 2356 ##
- Kyle Fry
- Zachary (Joe) Wilmot
- Adeja Mann
- Tyler Guadiano
- Moungsung Im
- Sudharshan Srinivasan

BlacFacs is a study-based learning application that teaches Black history and culture through games and interactive questions for the user to answer.

## Prototype Features
- Logging in to see a user's activity
- Selecting and searching through quizzes
- Taking the Quiz of the Day

## Technologies Used
- Unity 2021.3.11
- PHP
- WordPress (OnionBuzz & Ultimate Membership Pro)
- Firebase

## Getting the Project
1. First, ensure that Unity 2021.3.11 is installed. (https://unity3d.com/get-unity/download/archive). MAKE SURE THAT IOS AND ANDROID BUILD SUPPORT IS INSTALLED!!!
2. After installing Unity, clone the repo to a directory of your choice.
3. Open Unity Hub and select "Open Project" and navigate to the cloned repository. Select "BlacFacs-Unity" as the project directory.
4. Unity will now import the project.
5. Go to Project Settings via (File > Build Settings) and change the build type to iOS
6. Change the Product Name (default com.CompanyName) to "com.thirdeyeproductions.blacfacs". !!! FAILURE TO DO THIS WONT MAKE LOGIN WORK !!!
7. If not present in the Assets folder, ensure the BlacFacs Google Play Services .plist and .json files exist in the directory.
8. If not present in the Unity build, download the Firebase Unity SDK (https://firebase.google.com/download/unity) and unzip it.
9. Import the Firebase Auth Unity Package by going to (Assets > Import Package > Custom Package > firebase_unity_sdk folder > FirebaseAuth.unitypackage)
10. After importing, give it a second for all the scripts to compile and set in place.

