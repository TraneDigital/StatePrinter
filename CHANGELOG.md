![](https://raw.github.com/kbilsted/StatePrinter/master/StatePrinter/gfx/stateprinter.png)

# Version history

Full documentation on usage and motivating examples at https://github.com/kbilsted/StatePrinter/tree/master/doc

## V4.0 (unreleased)
  * Requires .NET Framework 4.7.2
  * Added `TestingBehaviour.SetAreEqualsMethod()` for easier integration with NUnit v3.x
  * Removed all obsolete functionality.

## 3.0.1 (last version for .NET framework 3.5)
  * Issue #48 Added `AnonymousFieldHarvester` for convenience
  * Issue #49 bugfix parsing brackets
  * Issue #51 bugfix thread problem
  * Performance improvements between 5%-40% 

## v3.0
  * Issue #38 fixed root name
  * Issue #40 fixed output format for xml and json
  * Issue #46, changed namespace from "Stateprinter" to "Stateprinting" in order for the project to be usable from VB#
  * 10% speed up
  * Changed the namespace from "StatePrinter" to "StatePrinting" in order to be CLS compliant (cross language support)
  


## v2.2.xxx-pr

* #43 Bugfix `\` in expected data failed on unit test rewrite due to lack of escaping.


## v2.2.281-pr
* Caching run-time generated getter methods.

## v2.2.274-pr

Added
* Improved performance by 10% for curly and json outputformatters
* #28 - General **50%-70% times speed up** of execution speed due to run-time code generation of reflection
* #31 - `RollingGuidValueConverter` - Unit testing data containing Guid's just became much easier
* Bugfixed the Json and Xml outputformatters when outputting dictionary/enumerables as the root element.


## v2.1.220

Added

  * Functionality for controlling automatic test rewrite using an environment variable.
  * Functionality for including or excluding fields and properties based on one or more type descriptions. See `IncludeByType()` and `ExcludeByType()`.
  * Added `AreAlike()`, replacing `IsSame()` (which is deprecated). Similar story for `PrintAreAlike` replacing `PrintIsSame()`. 
  * Made error message tell about `AreAlike()` when two strings are alike but not equals, when using `AreEquals()`.
  * Prepared for future expansion of functionality, by placing unit testing configuration in a sub-configuration class.
  * Obsoleted a lot of methods, describing the alternative API introduced in v2.1
  

Fixed

  * [#22 Make error message configurable upon assertion failure](https://github.com/kbilsted/StatePrinter/issues/22)


  
  
## v2.0.169

Added

* Added automatic unit test rewriting
* Added configuration of how line-endings are generated during state printing. This is to mitigate problems due to different operating systems uses different line-endings.
* Added assertion helper methods `Stateprinter.Assert.AreEqual`, `Stateprinter.Assert.IsSame`, `Stateprinter.Assert.PrintIsSame` and `Stateprinter.Assert.That`.  Improves the unit test experience by printing a suggested expected string as C# code.
* Added a `AllFieldsAndPropertiesHarvester` which is able to harvest properties and fields.
* `StringConverter` is now configurable with respect to quote character.
* BREAKING CHANGE: Projective harvester is now using the `AllFieldsAndPropertiesHarvester` rather instead of the `FieldHarvester`. This means both fields and properties are now harvested.


## v1.0.6

Added

* Executing stylecop on the build server.
* Made the `Configuration` class API a bit more fluent
* BUGFIX: Harvesting of types were cached across `Stateprinter` instances, which no longer makes sense since harvesting is configurable from instance to instance.
* BUGFIX: Changed how `ToString()` methods are harvested. Thanks to "Sjdirect".


## v1.0.5

Added

* Support for using the native `ToString()` implementation on types through a field harvester
* Added a Projective field harvester to easily reduce the harvesting of selective fields on types in a type-safe manner. See the section on unit testing in the readme.md
* Added the type `Stateprinter` and obsoleted the `StatePrinter` type


## v1.0.4


Added

* CLS compliance
* 20% Performance boost



Have fun!

Kasper B. Graversen
