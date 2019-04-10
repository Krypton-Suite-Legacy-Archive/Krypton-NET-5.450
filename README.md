# <img src="https://github.com/Wagnerp/Krypton-NET-5.450/blob/master/Assets/PNG/Square%20Design/Main%20Icon/64%20x%2064/Square%20Design%2064%20x%2064%20New%20Green.png"> .NET 4.50

=======

| NuGet | Current NuGet Version | Github License |
|---|---|---|
| [![NuGet](https://img.shields.io/badge/NuGet-Krypton%20.NET%205.450-brightgreen.svg)](https://www.nuget.org/packages/KryptonToolkitSuite5450/) | ![Nuget](https://img.shields.io/nuget/v/KryptonToolkitSuite5450.svg) | ![GitHub](https://img.shields.io/github/license/Wagnerp/Krypton-NET-5.450.svg) |

=======

# ["Toolkit help index"](https://rawgit.com/Wagnerp/Krypton-NET-4.7/master/Help/Output/index.html)

=======

## Available Versions
* [Krypton Toolkit Suite for .NET 4.7](https://github.com/Wagnerp/Krypton-NET-5.470)
* [Krypton Toolkit Suite for .NET 4.7.1](https://github.com/Wagnerp/Krypton-NET-5.471)
* [Krypton Toolkit Suite for .NET 4.7.2](https://github.com/Wagnerp/Krypton-NET-5.472)
* [Krypton Toolkit Suite for .NET 4.8](https://github.com/Wagnerp/Krypton-NET-5.480)

=======

## 2019-04-04 Build 856 - Bugfixes
* Fixed issue [#104](https://github.com/Wagnerp/Krypton-NET-5.470/issues/104), designer usage exceptions
* Fixed issue [#116](https://github.com/Wagnerp/Krypton-NET-5.470/issues/116), `KryptonManager` now displays themes and names correctly
* General fixes to `ThemeManager.cs` & `RibbonThemeManager.cs`
* Build 856 (build date Thursday 4th April, 2019) is now available on NuGet

=======

## 2019-03-25 Build 826 - MegaKarken Contributions
* Update example program for AllowDecimals
* Introduced an IconSpec definition for all KryptonDataGridViewColumn types so that icons can be drawn in KryptonDataGridView column header cells
* Adding a Multiline String Editor much like in VS' property grid to the KryptonTextBox control.
* Add Multiline String Editor in KryptonDataGridViewTextBox cells for multiline text editing
* Make MultilineStringEditor resizable.
* Adding KryptonDataGridViewCustomColumn type for DataGridViews
* Adding new KryptonDataGridViewBinaryColumn type for displaying and viewing binary data in GridViews.
* Make Hex-Mode default mode and add a button for exporting the data to a file.
* Slide panels instantly like Visual Studio
* Ignore DBNull.Value as well in GetFormattedValue
* Make the checkbox look a little nicer
* contextMenuStrip gradient color
* Adding a PaletteBackStyle.PanelCustom2 and PaletteBackStyle.PanelCustom3 for more theming flexibility
	* Continue to add custom numbers for the others custom# styles as well !
* Adding HoveredSelectionChanged event to KryptonComboBox
* Make KryptonDataGridViewComboBox accept objects rather than strings only
* Prop up KryptonComboBox with optional tooltips for items
* Extend support for DataGridView icons to Text & data cells
* Build 826 (build date Monday 25th March, 2019) is now available on NuGet

=======

## 2019-03-12 Build 792
* Code parity with 5.470
* New NuGet package

=======

## 2019-01-11 Build 700
* Code parity with 5.470
* New NuGet package

=======

## 2018-06-25 Initial commit
* Now you can export your custom palette creation in the `Krypton Palette Example` application.
* Start work on getting the system themes to display the extras. Issue #37 & #38
  * Not perfect but at least the "Chrome" displays the intended buttons and text(s).
* Removal of "not needed" casts.
* Remove the Designer dll (Project / code moved in Git)
* Place designers into actual dlls (Small size increase)
* Fix fallout from Designer dll removal from other projects
  * Fix build path output, and Demo Apps Ref path import and Output
* Remove hard-coded directory offsets for Component outputs
* Use offset location for components in Demo Apps 
* Remove Release GAC'ing
* Fix explorer for the copied target names
* DLL assembly names have been renamed to `Krypton Design`, `Krypton Docking`, `Krypton Navigator`, `Krypton Ribbon`, `Krypton Toolkit` and `Krypton Workspace`,  these changes do also apply to other binaries in this repo. However these changes does **NOT** affect the namespace names of `ComponentFactory.Krypton.xx`.
* Build output paths have been changed for easier installer authoring and synchronisation.
* Renamed repo title to `Krypton-NET-4.50` to better reflect versioning.
* Don't forget to add the TextExtra into the title width calculation
* Only Display "Ctrl+C..." for Error and Exclamation icon's
* Change the projects to at least recognise C#7.2 features and enhancements - _to be applied in the future_
* Some tinkering with spelling corrections - _to be applied in the future_
* Make the Help relevant to the Actual Code #17
* Change `bmp`'s to `png`'s
* Fix location of source for Help
* Change output to be clearer
* Remove previous output *leftovers*
* Add instructions on how to generate
* MessageBox taking a Null window owner (via default API's / null start / No KryptonManager loaded)
* Sort out the Toolkit examples to use the new dll locations
* Remove `BootstrapperPackage` .Net 3.5 nonsense from projects
* Remove hard coded build `Output Paths`
* The palette upgrade tool is now back! Enhancements over previous commercial version 4.4.0 include:
- Ability to export upgraded palette XML files
- Check to see if the output palette file is not saved before closing
* Exploration into a console version is in the works
* Changed some classes from `internal` to `public` for easier accessibility for the **Extended Toolkit**
* Renamed everything labelled `2015` to `2018`
* Each solution now has its own binary folder
* Build 553 (build date 15th February, 2018) has been released.
* Palette designer has been included with this release and future releases.
* Rename the ToolKit Examples to 2018
* Add the start of structured help and links
* Fix issue #28 - Undo changes that checked for null, and then would use a null, rather than return a null.. 
* Add initial API Help from `DocFX`
* Decompiled `chm` file ready for migration/updates
* New 7z file/directory in `Help` labelled `Help File Data` containing the contents of the `chm` file
* Remove duplicate information in `README.md`
* Add the `designer events` to describe the controls that have `TrackMouse Enter` and `Leave`
* Rename the projects to reflect year, to prevent confusion with old .net 4.5 projects
* Update test app to demonstrate `TrackMouse#### Events`
* Added descriptions to `OnTrackMouseEnter` and `OnTrackMouseLeave` events to make more sense
* Fixed bug with ComponentFactory.Krypton.Design.dll to version `4.50.0.0` due to hard coded values in toolkit code. Thanks to Smurf-IV for pointing this out to me.
* New Nuget package, version `4.70.524`, relating to the version of ComponentFactory.Krypton.Designer.dll (build date January 24th, 2018) will be uploaded to incorporate this fix.
* Renamed `GetCreateParams()` method to `DrawDropShadow()` in 'KryptonForm.cs' to avoid confusion
* Added/update documentation/comments for drop shadow methods in `KryptonForm.cs` to make functions clearer
* Convert to `'?:` expression
  * `null-coalescing` if applicable
  * Then to `Expression body` if simplified enough
* Fix some spelling mistakes along the way
* Add Ctrl+c text to `KryptonCommand`
* Fixed bug [Screen artifact, #79](https://github.com/ComponentFactory/Krypton/issues/79) courtesy of Cocotteseb
* Removed binaries due to merge issues
* Attempt at including drop shadow around the form
* Begin work on fixing bug [Screen artifact, #79](https://github.com/ComponentFactory/Krypton/issues/79)
* Groundwork for Visual Studio project & item templates
* Fix `AssemblyCopyright` information date ranges
* Create a Test project demonstrating MessageBox usage
  * Fix Mangled Caption that may contain carriage returns
  * Fix Box clipping on long and short text combinations
  * Add Extra text showing that Ctrl+C works in a `KryptonMessageBox`
* Code Headers changed:
  * Add correct license term and date range for ComponentFactory
  * Moved Wagnerp and Smurf-IV to later
* Use `nameof` for exception parameter references
* Add /// comments (on some public API's) stating that an exception can be returned if it explicitly __throws new__
* To reflect the .Net version move to Major.Minor of `4.50`
* Build will increment, with the final useless installable number left at zero
* Use "[Automatic Versions](https://marketplace.visualstudio.com/items?itemName=PrecisionInfinity.AutomaticVersions)" to perform the update build number action
* Changed year of all classes, controls etc from `2017` to `2018`
* Mass rebuild of solution
* Message content size adjustment in `KryptonTaskDialog`; ComponentFactory commit [5463f83](https://github.com/ComponentFactory/Krypton/commit/5463f835bcdbfffbafc9002923e0bea831bed211)
* Remove "Assignment is not used"
* Initialise orientation in mementos correctly
* CherryPick Merges from [Cocotteseb ](https://github.com/Cocotteseb/Krypton)
  * Docking : Get the KryptonWorkspaceCell from a page; commit [ea42f5f](https://github.com/Cocotteseb/Krypton/commit/fe2e778d49216215b8fb51c03c9ac3170f5a67c3)
  * Improvements to Krypton Workspace; commit [fe2e778](https://github.com/Cocotteseb/Krypton/commit/fe2e778d49216215b8fb51c03c9ac3170f5a67c3)
  * Draw text without a glowing background, for use on a composition element; commit [0286bd1](https://github.com/Cocotteseb/Krypton/commit/d3876704ad0ec24f5379a7febc1e3c3a1844e8af)
  * Modifications required for Krypton OutlookGrid; commit [d387670](https://github.com/Cocotteseb/Krypton/commit/7adde64817cfaa3967da1773774949a37d4b4a84)
  * Fixed an exception crash in KryptonTreeView; commit [7adde64](https://github.com/Cocotteseb/Krypton/commit/8d529d7a624c71c3ce22a7205f9116f0d443bb64)
  * Improvements Office2010 Black and first try Render Office 2013; commit [8d529d7](https://github.com/Cocotteseb/Krypton/commit/f85b69403a2e4359c546fb7d959dfd2c737491f1)
  * Windows 10 1511 enhancements + maximized windows bug fix trying; commit [71e5f32](https://github.com/Cocotteseb/Krypton/commit/621ab7c5ca1d7cd47f2c527ae1c18731b622b846)
  * Added KryptonMenuImageSelect click event; commit [621ab7c](https://github.com/Cocotteseb/Krypton/commit/ef4a415b84ac4ce9b145db9d723701a0099ce0f1)
  * Trying to fixed rare crashed in KryptonRibbon Composition; commit [ef4a415](https://github.com/Cocotteseb/Krypton/commit/c55aeadc2224ed68a7446bf3986eb02bf0415751)
  * Add DPI Awareness for Tab images (Mixture of commits)
* Update a few test to use Office 2013 palettes
* Remove "redundant delegate constructors" for callbacks
* Fix `OnClick` routing for 
  - ListBox
  - CheckedListBox
  - TextBox
  - TreeView
* Update the test project to see if click on TextBox's work as expected 
* Set some private fields to `readonly`
* Fix AddToWorkspace in KryptonDockingManager
* Change Get Set functions to be `inlined`
* Merge Sequential Checks
* Clarify precedence with brackets
* Add braces to if statements
* Use explicit types instead of `vars`
* Object initialization can be simplified
* Delegate invocation can be simplified.
* Use pattern matching 
  - Adjust some logic to test `bool` before cast
  - Use of switch if necessary
* Variable declaration can be `inlined`
* Null check can be simplified
  - null-propagating code
* Local Variable can be `const` (And rename to upper case to follow the rest of the codebase.)
* ﻿Join declaration and assignment
* An update to Component factory's KryptonToolkit to support the .NET 4.5 framework.
* Add generic c# .gitignore
* Change the solution to reflect Visual Studio 2017 usage
* Change Test apps to use .Net 4.5.0 Target framework
* Add designer Dll to test apps to allow visual design and testing without GAC'ing
* Work out why clipping is the default for `DrawText` 
  - Applies to buttons, Labels, Form Titles
  - Create test project - has theme selection, for type testing
* Remove Severity Code Description Project File Line Suppression State Warning CS0618 'SecurityAction.RequestMinimum' is obsolete: 'Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.' Basic Events 2015 [Source Path]\Krypton-NET-4.50\Source\Krypton Navigator Examples\Basic Events\Properties\AssemblyInfo.cs 35 Active
* Change Get Set functions to be `inlined`
* Merge Sequential Checks
* Clarify precedence with brackets
