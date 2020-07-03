# Original Xbox EEPROM Editor (Beta)

**NOTICE! - This application is still in the beta phase, please ensure you have an original backup of the EEPROM contents and an easy way to restore in case of issues.**
**Binaries won't be provided until further testing has been completed and the tool is deemed save to use.**

### Overview

This application allows for generating and/or editing the contents of an Original Xbox EEPROM.

### Requirements

.NET Framework 4.7.2 (Mono compatible)

### Build Instructions

##### Windows

* Build with [Visual Studio Community](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&rel=16#)

##### Linux

* Install [Mono](https://www.mono-project.com/download/stable/#download-lin)
* Clone: `git clone https://github.com/Ernegien/XboxEepromEditor.git`
* Enter source directory: `cd XboxEepromEditor/XboxEepromEditor`
* Compile: `xbuild XboxEepromEditor.csproj`
* Mark executable: `chmod +x bin/Debug/XboxEepromEditor.exe`
* Run: `./bin/Debug/XboxEepromEditor.exe`

### Attribution

[https://xboxdevwiki.net/EEPROM](https://xboxdevwiki.net/EEPROM)  
[https://github.com/mborgerson/xbeeprom](https://github.com/mborgerson/xbeeprom)  
[http://www.xbox-linux.org/down/The%20Middle%20Message-1a.pdf](https://web.archive.org/web/20040618164907/http://www.xbox-linux.org/down/The%20Middle%20Message-1a.pdf)  
Icon by [http://www.doublejdesign.co.uk](http://www.doublejdesign.co.uk) at [http://www.iconarchive.com/show/diagram-free-icons-by-double-j-design/chip-icon.html](http://www.iconarchive.com/show/diagram-free-icons-by-double-j-design/chip-icon.html)

### Previews

![Original Xbox EEPROM Editor - Application Image - Security Settings](Images/Security.png?raw=true "Security Settings")
![Original Xbox EEPROM Editor - Application Image - Factory Settings](Images/Factory.png?raw=true "Factory Settings")
![Original Xbox EEPROM Editor - Application Image - General Settings](Images/General.png?raw=true "General Settings")
![Original Xbox EEPROM Editor - Application Image - Parental Control Settings](Images/Parental.png?raw=true "Parental Control Settings")
![Original Xbox EEPROM Editor - Application Image - Live](Images/Live.png?raw=true "Live Settings")
![Original Xbox EEPROM Editor - Application Image - Unknown Values](Images/Unknown1.png?raw=true "Unknown Values")
![Original Xbox EEPROM Editor - Application Image - Unknown Flags](Images/Unknown2.png?raw=true "Unknown Flags")
