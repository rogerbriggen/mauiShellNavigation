# mauiShellNavigation

Shows the problem of the not working shell navigation 

If you navigate so there are multiple childs and then you want immediatly return to the root the title of the root page is shown but the content is not updated on Windows. It works as expected on Android.

- In this example press the button so you navigate to SecondPage which is the first child. 
- Press again the button to navigate to third page
- Press again the button you should navigate back to the root -> the title changes to Home again which is correct but not the page content

It works if you only have 1 child so you can change the code in the MainPage to navigate directly to the ThirdPage, then everything works as expected.

See also ThirdPage.xaml.cs OnCounterClicked for various methods which none is a real workaround.
