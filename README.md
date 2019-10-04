# _Word Counter Application_

#### _A console application that counts the number of times a specific word appears in a sentence; 04-October-2019_

#### By _**Mike McShane**_

## Description

_A console application that counts the number of times a specific word appears in a sentence. Will not count partial word matches._

## Specifications

| Behavior | Input | Output|
|:------|:---------:|:------:|
| It counts the number of times a specific word is used. | "cat", "the cat is old" | "1" |

This is the first test to see if the method can count the key word in a sentence with no punctuation.

| Behavior | Input | Output|
|:------|:---------:|:------:|
| It can count the key word whether it is uppercase or lowercase | "cat", "the Cat is old" | "1" |

This test makes sure the inputed user string and user key word are transformed to all lowercase when compared.

| Behavior | Input | Output|
|:------|:---------:|:------:|
| It will not count partial matches | "cat", "the cat is a caterer" | "1" |

This is the second test to see if the method will ignore partial matches of the key word.

| Behavior | Input | Output|
|:------|:---------:|:------:|
| It counts multiple matches of the submitted word | "one cat, two cat, red cat, blue cat." | "4" |

This test ensures the method will count multiple instances of the key word.

| Behavior | Input | Output|
|:------|:---------:|:------:|
| It counts words that follow basic plural structure | "This cat is one of my favorite cats ever." | "2" |

The final test adds plurals to the key word count. Only handles plurals that follow the basic 'word' + 's' convention.


## Setup/Installation Requirements_

* _Clone this repository_
* _Navigate to the directory_
* _Run "dotnet run" command to open application in the command console_

## Known Bugs

_N/A_

## Support and contact details

_Google_

## Technologies Used

_C#, .NET_

### License

*open source*

Copyright (c) 2019 **_Mike McShane_**