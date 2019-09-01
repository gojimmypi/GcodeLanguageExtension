# Release History
Edit releawse in Project Properties - Assembly Information and source.extension.vsixmanifest Version.

## Version 0.1.5
  not distributed, testing VS2015 issues

## Version 0.1.4

Addressed [#2](https://github.com/gojimmypi/GcodeLanguageExtension/issues/2) to highlight syntax for
`.nc`, `.mpt`, `mpf` files in addition to `.gcode`.

## Version 0.1.3
Fixed VS2015 compatibility. (manual edits of project file, capred to working VerilogLanguage project)



Hi! I'm glad someone is actually using this extension :)

I've added support to highlight syntax for `.nc`, `.mpt`, `mpf` files in addition to `.gcode`. Please see version `0.1.4`.

If you are interested, I have code for [another project](https://github.com/gojimmypi/VerilogLanguageExtension/blob/master/README.md) that not only highlights code, but also has hover text top actually indicate what the respective keyword means. 

Perhaps if you could provide a list of all the g-codes - ideally in plain text, comma -delimited format, and their respective meaning, I could add this feature as well? (feel free to open a new issue for this ).

As for your questions: Yes - any sort of "register itself" for different file extensions would definitely require a code change. 

Regarding the option for a dialogue to configure... well, everything is easy when you know how - but I'm not sure how this would work. 


