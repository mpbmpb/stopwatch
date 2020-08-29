
<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
![Coverage][coverage-shield]
![Tests][tests-shield]
![GitHub code size in bytes][codesize-shield]
[![Contributors][contributors-shield]][contributors-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]




<!-- PROJECT LOGO -->
<br />
<p align="center">
<a href="https://github.com/mpbmpb/stopwatch">
   <img src="/gitAssets/time.svg" height="100" width="100">
</a>

  <h3 align="center">Stopwatch</h3>

  <p align="center">
    <a href="https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop">
    <img src="/gitAssets/csharpintermediate.jpg"></a>
    <br />
    <br />
    <br />
    A coding exercise from the udemy course C# intermediate
    <br />
    <a href="https://www.udemy.com"><img src="/gitAssets/udemylogo.svg" height="90" width="90"></a>
    <br />
    <a href="https://github.com/mpbmpb/stopwatch/issues">Report Bug</a>
    ·
    <a href="https://github.com/mpbmpb/stopwatch/issues">Request Feature</a>
  </p>
</p>



<!-- TABLE OF CONTENTS -->
## Table of Contents

* [About the Project](#about-the-project)
  * [Built With](#built-with)
  * [Specifications](#specifications)
* [Getting Started](#getting-started)
  * [Prerequisites](#prerequisites)
  * [Installation](#installation)
* [Usage](#usage)
* [Roadmap](#roadmap)
* [Contributing](#contributing)
* [License](#license)
* [Contact](#contact)
* [Acknowledgements](#acknowledgements)



<!-- ABOUT THE PROJECT -->
## About The Project
<p align="center">
  <img src="/gitAssets/code.jpg" width="480" height="300">
</p>
This is a short console app written as an exercise given in de udemy course C# Intermediate by Mosh Hamedani.
<br/>
It is a simple stopwatch app with a short test that prints to the console.
<br/>
<br/>
I wrote all of the exercises for this course using the TDD approach of writing tests first and then production code.
The tests are written using xUnit and Fluent Assertions.
<br/>
<br/>
Thank you Mosh Hamedani for making a comprehensive and easy to follow course. :star:

A list of commonly used resources that I found helpful are listed in the acknowledgements.

### Built With
The code was written in Visual Studio.<br/>
The test coverage was measured with JetBrains dotCover.

* [Visual Studio](https://docs.microsoft.com/en-us/visualstudio/install/install-visual-studio?view=vs-2019)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp)
* [xUnit](https://xunit.net)
* [Fluent Assertions](https://fluentassertions.com/)
* [dotCover](https://www.jetbrains.com/dotcover/)

### Specifications
The given specifications were:

* Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should provide two methods: Start and Stop. We call the start method first, and the stop method next. Then we ask the stopwatch about the duration between start and stop. Duration should be a value in TimeSpan. Display the duration on the console.

* We should also be able to use a stopwatch multiple times. So we may start and stop it and then start and stop it again. Make sure the duration value each time is calculated properly.

* We should not be able to start a stopwatch twice in a row (because that may overwrite the initial start time). So the class should throw an InvalidOperationException if its started twice.


<!-- GETTING STARTED -->
## Getting Started

To get a local copy up and running follow these simple example steps.

### Prerequisites

Visual Studio needs to be installed along with the dotnet core runtime and SDK
All can be installed by the Visual Studio installer.

* The installer can be found on this page 
```sh
[Visual Studio documentation](https://docs.microsoft.com/en-us/visualstudio/install/install-visual-studio?view=vs-2019)
```

### Installation

1. Open Terminal
2. Navigate to the directory where you want to install the files
3. Clone the repo
```sh
git clone https://github.com/mpbmpb/stopwatch.git
```
3. go to the stopwatch directory
```sh
cd stopwatch
```
4. run the app from the terminal
```
dotnet run
```
5. or find the stopwatch.sln file in your explorer and double click it.
   Visual Studio should take it from there.


<!-- USAGE EXAMPLES -->
## Usage

This project is meant purely as an educational exercise.

<!-- ROADMAP -->
## Roadmap

There are currently no plans to expand this project.
Feel free to contribute if you want to add something.

<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE` for more information.



<!-- CONTACT -->
## Contact
Feel free to contact me if you have questions or suggestions.

Mark van den Beemt - markkeyster@gmail.com

Project Link: [https://github.com/mpbmpb/stopwatch](https://github.com/mpbmpb/stopwatch)



<!-- ACKNOWLEDGEMENTS -->
## Acknowledgements
* [Mosh Hamedani's C# intermediate course](https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop)
* [GitHub best readme template](https://github.com/othneildrew/Best-README-Template)
* [GitHub Emoji Cheat Sheet](https://www.webpagefx.com/tools/emoji-cheat-sheet)
* [Img Shields](https://shields.io)
* [Choose an Open Source License](https://choosealicense.com)
* [GitHub Pages](https://pages.github.com)
* [flaticon](https://www.flaticon.com)
* [unsplash](https://unsplash.com)
* <span>Photo by <a href="https://unsplash.com/@markusspiske?utm_source=unsplash&amp;utm_medium=referral&amp;utm_content=creditCopyText">Markus Spiske</a> on <a href="https://unsplash.com/s/photos/code?utm_source=unsplash&amp;utm_medium=referral&amp;utm_content=creditCopyText">Unsplash</a></span>
* <div>Icons made by <a href="http://www.freepik.com/" title="Freepik">Freepik</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a></div> 





<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[coverage-shield]: https://img.shields.io/badge/coverage-100%25-brightgreen
[tests-shield]: https://img.shields.io/badge/tests-passing-brightgreen
[contributors-shield]: https://img.shields.io/github/contributors/mpbmpb/stopwatch?color=blue&style=flat-square
[contributors-url]: https://github.com/mpbmpb/stopwatch/graphs/contributors
[codesize-shield]: https://img.shields.io/github/languages/code-size/mpbmpb/stopwatch
[stars-shield]: https://img.shields.io/github/stars/mpbmpb/stopwatch
[stars-url]: https://github.com/mpbmpb/stopwatch/stargazers
[issues-shield]: https://img.shields.io/github/issues/mpbmpb/stopwatch?style=flat-square
[issues-url]: https://github.com/mpbmpb/stopwatch/issues
[license-shield]: https://img.shields.io/github/license/mpbmpb/stopwatch
[license-url]: https://github.com/mpbmpb/stopwatch/blob/master/LICENSE
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=flat-square&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/mark-van-den-beemt-7805011b1/
