var Lletter : GameObject;
var scoreText : GameObject;
var livesText : GameObject;
var walkingSpeed : double;
var livesNumber : int;
var scoreNumber : int;

function Start () {
    Lletter = GameObject.Find("Lletter");
	scoreText = GameObject.Find("Score");
	livesText = GameObject.Find("Lives");

	//Initialize the values of walking speed
	walkingSpeed = 0.0;
	livesNumber = 3;
	scoreNumber = 0;

	//Initialize the GUI components
	livesText.GetComponent(UI.Text).text = "Lives Remaining: " + livesNumber;
	scoreText.GetComponent(UI.Text).text = "Score: " + scoreNumber;

	//Place the ant in a random position on start of the game
	Lletter.transform.position.x = generateX();
	Lletter.transform.position.y = generateY();
}

function Update () {	

    if(Lletter.transform.position.y < -4.35 && livesNumber > 0){	
		
		livesNumber -= 1;
		livesText.GetComponent(UI.Text).text = "Lives Remaining: " + livesNumber;
		generateCoordinates();

    }else if(Lletter.transform.position.y < -4.35 && livesNumber == 0){
	    Destroy(GameObject.Find("Lletter"));
		gameOver();

	}else{

        Lletter.transform.position.y -= walkingSpeed;
	}
}

function gameOver(){	
	Application.LoadLevel("GameOver");
}


//Generates random x
function generateX(){
	var x = Random.Range(-2.54,2.54);
	return x;
}

//Generates random y
function generateY(){
	var y = Random.Range(-4.0,3.8);
	return y;
}

//Move the "Lletter" to the new coordiantess
function generateCoordinates(){
	//You clicked it!
	scoreNumber += 1;

	//Update the score display
	scoreText.GetComponent(UI.Text).text = "Score: " + scoreNumber;
	Lletter.transform.position.x = generateX();
	Lletter.transform.position.y = generateY();
}

//If tapped or clicked
function OnMouseDown(){
    //Place the Lletter at another point
	generateCoordinates();

	//Increase the walking speed by 0.01
	walkingSpeed += 0.01;
}