# BigfootUnityUtilities

Example of using Github Actions to generate Unity UPM & legacy packages.

This is mainly an educational example - the project, workflow & results are all visible.


## What is this?

The Unity project itself is an example of some code you might want to use across multiple different projects - a resource, that you would use via a package file or package manager!

So, you can see the Unity project - it's right in the root of the repository.

The real magic here comes from the workflow file named "unitypackage.yml", located in ".github/workflows". Here, you can see lots of YAML that will generate both a legacy Unity package ".package" file, as well as deploy the project to the unofficial Unity Package Manager Registry. 

The legacy Unity package file is available in the releases section of this repository.

The UPM package is available here: 

## Resources used:

* The "create-unitypackage" action from the Github Marketplace, by Github user pCYSl5EDgo. Link: https://github.com/marketplace/actions/create-unitypackage
* The "Github Releases" action from the Github Marketplace, by Github users fnkr, harshzalavadiya, and rokibhasansagar. Link: https://github.com/marketplace/actions/github-releases 
* The "Public UPM" action from the Github Marketplace, by Github user monry. Link: https://github.com/marketplace/actions/publish-upm 


# TODO

* Automated semantic versioning. Yeah, I know.