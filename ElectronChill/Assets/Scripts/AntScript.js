import UnityEngine.UI;
var Circle_timer:  UnityEngine.UI.Image;
var Lletter : GameObject;
var Nletter : GameObject;
var MLletter : GameObject;
var scoreText : GameObject;
var livesText : GameObject;
var walkingSpeed : double;
var livesNumber : int;
var scoreNumber : int;
var waitTime  : float;
var rayHit: RaycastHit;
var timer : float = 0.0;
var timeLimit : float = 5.0;

function Start () {
    Lletter = GameObject.Find("Lletter");
    Nletter = GameObject.Find("Nletter");
    MLletter = GameObject.Find("Lletter");
    scoreText = GameObject.Find("Score");
    livesText = GameObject.Find("Lives");
    Circle_timer = GameObject.Find("Circle_timer").GetComponent(Image);
    
    //Initialize the values of walking speed
    walkingSpeed = 0.0;
    livesNumber = 3;
    scoreNumber = 0;
    waitTime = 30.0f;

    //Initialize the GUI components
    livesText.GetComponent(UI.Text).text = "Lives Remaining: " + livesNumber;
    scoreText.GetComponent(UI.Text).text = "Score: " + scoreNumber;

    //Place the ant in a random position on start of the game
    Lletter.transform.position.x = generateX();
    Lletter.transform.position.y = generateY();

    // Nletter.SetActive(false);
    //GameObject.Find("Nletter").GetComponent(Renderer).enabled = false;
    //GameObject.Find("Lletter").GetComponent(Renderer).enabled = false;
    //GameObject.Find("MLletter").GetComponent(Renderer).enabled = false;
}

function Update () {	

	timer+=Time.deltaTime;
    if (timer >= timeLimit){
       timer = 0.0;


	   //r = Random.Range(-4.0,4.0);

	   generateCoordinates(Nletter);
	   generateCoordinates(Lletter);
	   generateCoordinates(MLletter);
	   //if ()
	   GameObject.Find("Nletter").GetComponent(Renderer).enabled = true;
	   GameObject.Find("Lletter").GetComponent(Renderer).enabled = !GameObject.Find("Lletter").GetComponent(Renderer).enabled ;
	   GameObject.Find("MLletter").GetComponent(Renderer).enabled = true; 
    }
	
    /*if(Lletter.transform.position.y < -4.35 && livesNumber > 0){	
		
        livesNumber += 1;
        livesText.GetComponent(UI.Text).text = "Lives Remaining: " + livesNumber;
        generateCoordinates();

    }else if(Lletter.transform.position.y < -4.35 && livesNumber == 0){
        Destroy(GameObject.Find("Lletter"));
       

    }*/else{

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

function generateLetter(){
	var r = Random.Range(1,3);
    //Update the score display
   // GameObject.Find("MLletter").GetComponent(Renderer).enabled;
    scoreText.GetComponent(UI.Text).text = "Score: " + scoreNumber;
    Lletter.transform.position.x = generateX();
    Lletter.transform.position.y = generateY();
}

//Move the "Lletter" to the new coordiantess
function generateCoordinates(obj){
    //You clicked it!
    scoreNumber += 1;
    var o : GameObject = obj;
    //Update the score display
    scoreText.GetComponent(UI.Text).text = "Score: " + scoreNumber;
    o.transform.position.x = generateX();
    o.transform.position.y = generateY();
}

//If tapped or clicked
function OnMouseDown(){
	var lastClicked : GameObject = rayHit.collider.gameObject;
    //Place the Lletter at another point

    generateCoordinates(lastClicked);
    timer = 0.0;
    //Increase the walking speed by 0.01
    //walkingSpeed += 0.01;
}