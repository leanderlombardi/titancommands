#!/bin/bash

DIR=out
if [ -d "$DIR" ];
then
:
else
	mkdir out
fi

helpFunction() {
    echo ""
    echo "------------------------------------------------"
    echo "| Usage: ./execute.sh [-d|-f|-a]               |"
    echo "|                                              |"
    echo "| d: Installs tools (debian, e. g. Ubuntu)     |"
    echo "| f: Installs tools (fedora, e. g. Fedora)     |"
    echo "| a: Installs tools (arch, e. g. Manjaro)      |"
    echo "------------------------------------------------"
    echo ""
}

if [ "$1" == "-d" ]
then
	sudo apt update
	sudo apt upgrade
	sudo apt install mono-complete -y
elif [ "$1" == "-f" ]
then
	sudo dnf update
	sudo dnf install mono-devel
elif [ "$1" == "-a" ]
then
	sudo pacman -Syu
	sudo pacman -S mono
elif [ -z "$1" ]
then
	filedir=$RANDOM
	mcs -out:out/$filedir.exe src/main.cs
	mono out/$filedir.exe
	rm out/$filepath.exe
else
then
	helpFunction
fi
