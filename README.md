swxben.Windows.Forms
====================

A small library of Winforms based dialogs and helpers


## Installation
Install via [NuGet](http://nuget.org/packages/swxben.Windows.Forms), either in Visual Studio (right-click project, Manage NuGet Packages, search for swxben.Windows.Forms) or via the package manager console using `Install-Package swxben.Windows.Forms`.


## Usage

Live, hopefully working examples are in the test application. All of the forms can be opened using `ShowDialog()` which returns either `DialogResult.OK` or `DialogResult.Cancel`. Each of the dialogs implements a public interface allowing for use with a DI container and mocking in tests.


### swxben.Windows.Forms.Dialogs


#### DateTimePromptDialog

Select a date.

    var prompt = new DateTimePromptDialog("Select your birthday:", "Select birthday", new DateTime(2000, 01, 01));

    // reset values
    prompt.SetValues("Select invasion date (in the future)", "Select invasion date", DateTime.Now.Date.AddDays(1));
    prompt.SetMinDate(DateTime.Now.Date.AddDays(1));
    
    prompt.ShowDialog();	// == DialogResult.OK or DialogResult.Cancel


#### GenericListSearchDialog

Generic-typed item selection with string search.

    class Person { string Name; }
    // ...
    var people = new Person[] {...};
    var search = new GenericSearchDialog("Select a person", people, person => person.Name);
    search.ShowDialog();
    // search.SelectedItem is the selected Person object

`GenericListSearchDialog` has a `FixWidth()` method which increases the width of the dialog based on the width of the items in the list.


#### GenericDetailedListSearchDialog

Similar to `GenericListSearchDialog` but receives an array of column names, and the display callback returns a corresponding array of column values.

    class Person { string Name; string Age; }
    // ...
    var people = new Person[] {...};
    var search = new GenericDetailedListSearchDialog(
        "Select a person", 
        people, 
        new[] { "Name", "Age" },
        person => new[] { person.Name, person.Age.ToString() });
    search.ShowDialog();
    // search.SelectedItem is the selected Person object

`GenericDetailedListSearchDialog` has a `FixWidth()` method which increases the width of the dialog based on the width of the items in the list.


#### StringListSearchDialog

Search through a list of strings.

    var search = new StringListSearchDialog("Select a language", new[] { "C#", "C++", "Ruby", "Scala", "Javascript", "Java"});
    search.ShowDialog();
    // search.SelectedItem is the selected string

`StringListSearchDialog` has a `FixWidth()` method which increases the width of the dialog based on the width of the items in the list.


#### TextPromptDialog

Enter a text value.

	var prompt = new TextPromptDialog("What is the driver's name:", "Driver name", "Jane");
	prompt.ShowDialog();
	// prompt.Value is the entered string


### swxben.Windows.Forms.Controls

#### WatermarkedTextBoxExtension

Support for watermarking a textbox. Based on a [pastebin](http://pastebin.com/iFzanuC2) from [Jack](http://stackoverflow.com/a/9303203/149259).

    using swxben.Windows.Forms.Controls;
    //...
    textBox.SetWatermark("Username");


## Contribute

If you want to contribute to this project, start by forking the repo: <https://github.com/swxben/swxben.Windows.Forms>. Create an issue if applicable, create a branch in your fork, and create a pull request when it's ready. Thanks!

### Contributors


## Licenses

All files [CC BY-SA 3.0](http://creativecommons.org/licenses/by-sa/3.0/) unless otherwise specified.

### Third party licenses

Third party libraries or resources have been included in this project under their respective licenses.
