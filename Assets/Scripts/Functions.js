function loadGame(){
	Application.LoadLevel("Game");
}

function loadMenu(){
	Application.LoadLevel("Menu");
	Time.timeScale = 1;
	AudioListener.pause = false;
}

function loadEasy(){
	Application.LoadLevel("easy");
}

function loadHard(){
	Application.LoadLevel("hard");
}

function loadDifficulty(){
	Application.LoadLevel("Difficulty");
}

function quit(){
	Application.Quit();
}