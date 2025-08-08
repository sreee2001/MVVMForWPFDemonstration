#  Demonstration of different MVVM Implementations For WPF

I am showcasing three different ways MVVM can be implemented in WPF, for quick reference
- [Model First](https://github.com/sreee2001/MVVMForWPFDemonstration/tree/master/ModelFirstMVVM)
- [View First](https://github.com/sreee2001/MVVMForWPFDemonstration/tree/master/ViewFirstMVVM)
- [ViewModel First](https://github.com/sreee2001/MVVMForWPFDemonstration/tree/master/ViewModelFirstMVVM)

I also added in a [Basic MVVM](https://github.com/sreee2001/MVVMForWPFDemonstration/tree/master/BasicMVVM) Project, just for the sake of it

# Overview

In the Model-View-ViewModel (MVVM) architectural pattern, the terms "View-First" and "ViewModel-First" describe different approaches to the creation and composition of the View and ViewModel components. "Model-First" refers to a distinct approach in database or data modeling, not directly related to the View/ViewModel composition in MVVM.

1. View-First Approach:
  - Order of Creation: The View is instantiated first.
  - Relationship Establishment: The View then creates or obtains its corresponding ViewModel and sets it as its DataContext (or equivalent mechanism for binding).
  - Characteristics:
    *  The View explicitly knows about its ViewModel.
    *  Often involves code-behind in the View to instantiate and connect the ViewModel.
    *  Can be simpler to set up initially for individual views.
2. ViewModel-First Approach:
  -  Order of Creation: The ViewModel is instantiated first.
  -  Relationship Establishment: The ViewModel (or a service it uses) is responsible for creating or locating the appropriate View to display itself. This is often achieved through mechanisms like DataTemplates or View-locating services.
  -  Characteristics:
     *  The ViewModel is decoupled from the specific View implementation.
     *  Promotes testability as ViewModels can be tested independently of the UI.
     *  Enables more complex navigation and composition scenarios where ViewModels drive the application flow.
     *  Can be more complex to set up initially due to the need for View-ViewModel mapping or location services.
3. Model-First (in Data Modeling):
  - Context:
     *  This term primarily applies to database design or data modeling, particularly in frameworks like Entity Framework.
  - Approach:
     *  You design your data model (entities, relationships) conceptually, and then the framework generates the database schema and corresponding code (e.g., entity classes) from this model.
  - Relation to MVVM:
     *  While the Model in MVVM represents your application's data and business logic, "Model-First" as an approach to View/ViewModel composition is not a standard concept within MVVM itself. The Model in MVVM exists independently of how the View and ViewModel are instantiated and connected.
