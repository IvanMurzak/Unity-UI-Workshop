# Unity UI (UGUI), Tips & Tricks

Sample project that explains basics of UI implementation in Unity project.

## Packages

A pack of files, usually scripts for easy integration into the project. May have dependencies on another package(s).

- `OpenUPM` - a repository Unity of packages.
  - > You can upload your packages there as well. Use this [GitHub Template](https://github.com/IvanMurzak/Unity-Package-Template) to make it easier.
- `OpenUPM-CLI` - command line tool for adding packages to Unity project.

### Setup

- Step 1: `Node.js` installation - https://nodejs.org/en/download/
- Step 2: `OpenUPM-CLI` installation

  ```bash
  npm install -g openupm-cli
  ```

#### [UI Effect](https://github.com/mob-sakai/UIEffect)

```bash
openupm add com.coffee.ui-effect
```

#### [Mouse Parallax](https://github.com/IvanMurzak/Unity-Mouse-Parallax)

```bash
openupm add extensions.unity.mouse.parallax
```

#### [Particle Effect for UGUI](https://github.com/mob-sakai/ParticleEffectForUGUI)

Add the reference to your project

```bash
openupm add com.coffee.ui-particle
```
