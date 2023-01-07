# TitanCommands Language
Project made in C# by Leander Lombardi

---
## Get started
---
**You will need these steps later.**\
--> You need to have a mono installed.\
If you already have it, execute your program with these steps:
### Linux
---
```bash
$ ./execute.sh
```
Note: If you use `execute.sh` for the first time, you have to type:
```bash
$ chmod +x ./execute.sh
```
Else, it will give you an error.

---
--> If you do not have mono installed, execute these steps first:
### Linux
#### Debian-based systems (e. g. Ubuntu) | apt
```bash
$ sudo ./execute.sh -d
```
#### Arch-based systems (e. g. Manjaro Linux) | pacman
```bash
$ sudo ./execute.sh -a
```
#### Fedora systems | dnf
```bash
$ sudo ./execute.sh -f
```
## Hello, world!
---
You need to make a file, for example, we'll call it `HelloWorld.tcm` and save it under `/home/leander/Examples`.
In this program, we'll write:
```
println("Hello, world!");
```
Then, we'll save this file. To then execute this, use the steps shown above. It should then look like this:
```
TitanCommands Shell >>> 
```
Into the prompt, you have to type in the **full** path to your file:
```
TitanCommands Shell >>> /home/leander/Examples/HelloWorld.tcm
```
Our output should be like this:
```
TitanCommands Shell >>> /home/leander/Examples/HelloWorld.tcm

*****************
* TitanCommands *
*  O U T P U T  *
*****************

Hello, world!
```
