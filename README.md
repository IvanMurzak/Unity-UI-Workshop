# Unity UI (UGUI), Tips & Tricks

This sample project demonstrates the fundamentals of UI implementation in a Unity project.


🔴 [Full workshop video on YouTube](https://youtu.be/ESmqOLMujJY).


### Definitions

- **Package**: A bundle of files, typically scripts, designed for easy integration into a project. These may depend on other packages.
- **OpenUPM**: A repository of Unity packages.
  - > You can also upload your packages here. To facilitate this, use this [GitHub Template](https://github.com/IvanMurzak/Unity-Package-Template).
- **OpenUPM-CLI**: A command-line tool for adding packages to your Unity project.

# Setup

1. **Install Node.js**: Download and install Node.js from [https://nodejs.org/en/download/](https://nodejs.org/en/download/).
2. **Install OpenUPM-CLI**:

    ```bash
    npm install -g openupm-cli
    ```

3. Windows only: Set System Environment Variable

    Path: `C:\Users\USER_NAME\AppData\Roaming\npm` (don't forget to replace `USER_NAME`)

4. Windows only: You may need to run the command to allow to run scripts on the computer

    ```
    Set-ExecutionPolicy RemoteSigned -Scope CurrentUser
    ```

### Install all packages

Run the following command in your project's directory:

```bash
openupm add extensions.unity.mouse.parallax
openupm add extensions.unity.theme
openupm add extensions.unity.nondrawinggraphic
openupm add com.coffee.ui-effect
openupm add com.coffee.ui-particle
openupm add com.unity.probuilder
```

# [Mouse Parallax](https://github.com/IvanMurzak/Unity-Mouse-Parallax)

![198884624-d8dacd24-41db-4488-b33c-59102809c336](https://github.com/user-attachments/assets/85b46138-de3c-4b03-af8d-994e88b3415b)

Run the following command in your project's directory:

```bash
openupm add extensions.unity.mouse.parallax
```

# [Unity Theme](https://github.com/IvanMurzak/Unity-Theme)

![263363646-1c545d11-aea4-4cd2-8aaa-75539bbb6699](https://github.com/user-attachments/assets/05e53dc0-43f8-4ef0-bdf5-45797d2e64b1)

Run the following command in your project's directory:

```bash
openupm add extensions.unity.theme
```

# [UI Effect](https://github.com/mob-sakai/UIEffect)

![uieffects](https://github.com/user-attachments/assets/1fa335e5-5316-4aa0-8ee5-4721c7e96641)

Run the following command in your project's directory:

```bash
openupm add com.coffee.ui-effect
```

# [Particle Effect for UGUI](https://github.com/mob-sakai/ParticleEffectForUGUI)

![41771577-8da4b968-7650-11e8-9524-cd162c422d9d](https://github.com/user-attachments/assets/13f69a90-98b6-4ff8-85d2-03bbc210ce26)

Run the following command in your project's directory:

```bash
openupm add com.coffee.ui-particle
```
