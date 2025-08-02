
THIS IS A FORK
CHECK OUT THE ORIGINAL PLEASE



=-=
=-=
=-=
=-=


# Local AI

Code from this youtube video: https://youtu.be/LD6x8EkJbLw

The code is pretty basic and was smashed together from online tutorials and stackoverflow but it works.
There still is a lot to improve on and I will be working on it.

## Future ideas:
- code starts ollama automatically
- Speed improvements
- Model switching from program UI.

## Requirements
- At least **16gb RAM** (32gb+ recommended, I have 64gb)
- [Ollama](https://ollama.com/download)

## Get It Running

### 1. Install Ollama

Download and install Ollama:  
https://ollama.com/download

You can test it by typing the version command:
> ollama -v

After installation, open your terminal and run this command to download a model:
> ollama run llama3

That command will download and start the `llama3` model locally.

### 2. Clone this repo

Download the code:
> git clone https://github.com/CsharpProgramming/LocalAI.git

Open the project in Visual Studio.

### 3. Change Model (Optional)

In form 1 you can change line 49 to the model you downloaded:
> SelectedModel = "llama3:latest"

You can also try models from the ollama model list:
https://ollama.com/library?sort=popular

### 4. Run the program
Start Ollama:
> ollama run llama3

> ollama serve

Go into the form1 code and check line 46 is your ollama server the same (should be by default):
> var uri = new Uri("http://localhost:11434")

After this, just run the program and you should be good to go!
