## Asp.Net Webapi + MVC + Entity Framework + Angular CLI

## Prerequisites

The project have dependencies that require ASP.Net 4.5, Node 6.9.0 or higher, NPM 3 or higher, together with [Angular CLI](https://github.com/angular/angular-cli) 1.1.2 or higher. 

## Table of Contents

* [Installation](#installation)
* [Usage](#usage)
* [Generating Components, Directives, Pipes and Services](#generating-components-directives-pipes-and-services)
* [Documentation](#documentation)
* [License](#license)

## Installation

**BEFORE YOU INSTALL:** please read the [prerequisites](#prerequisites)

## Usage

Reinstall nuget package in Package Manager Console

```bash
Update-Package -reinstall
```

Install node modules in `webapp` folder
```bash
npm install
```

Test or develop `webapp` project
```bash
ng serve -o
```

Build the Angular CLI and create `dist` folder
```bash
ng build -prod
```
 
 Copy files from `dist` folder to `content` folder of web api project
```bash
gulp 
```

### Generating Components, Directives, Pipes and Services

You can use the `ng generate` (or just `ng g`) command to generate Angular components:

```bash
ng generate component my-new-component
ng g component my-new-component # using the alias

# components support relative path generation
# if in the directory src/app/feature/ and you run
ng g component new-cmp
# your component will be generated in src/app/feature/new-cmp
# but if you were to run
ng g component ../newer-cmp
# your component will be generated in src/app/newer-cmp
# if in the directory src/app you can also run
ng g component feature/new-cmp
# and your component will be generated in src/app/feature/new-cmp
```
You can find all possible blueprints in [Angular CLI](https://github.com/angular/angular-cli/#generating-components-directives-pipes-and-services) webstie.


## Documentation

The documentation for the Angular CLI is located in this repo's [wiki](https://github.com/angular/angular-cli/wiki).

## License

MIT