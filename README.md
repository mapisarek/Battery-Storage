# Battery storage application

Application made to order that allows you to store information about your batteries in a warehouse. 
Made with use of .NET and WPF Microsoft technologies.
Due to its intended use, UI had to be made in polish language.

## Features
* Searching for an item from the warehouse by name
* Filtering by battery parameter
* Adding a new item to the stored list
* Removing selected battery from storage
* Export the created list to a text file

## Architecture & method of implementation
* MVVM Pattern [(Model-View-ViewModel)](https://en.wikipedia.org/wiki/Model%E2%80%93view%E2%80%93viewmodel)
* ObservableCollection to store Battery model
* CollectionViewSource to provide filtering / searching feature

## Program preview

<img src="https://github.com/mapisarek/Battery-Storage/Preview/Accum.PNG">
