using Godot;
using System;
using System.Collections.Generic;
//hello

public partial class Main : Node2D
{  private Player player;

	// Dobbelsteen dobbelDefault = new Dobbelsteen(0, 4);
	// Dobbelsteen dobbelUpgrade1 = new Dobbelsteen(1, 4);
	// Dobbelsteen dobbelUpgrade2 = new Dobbelsteen(1, 7);
	// Dobbelsteen dobbelUpgrade3 = new Dobbelsteen(-3, 10);
	
	// private Node2D player1;
	// private Node2D player2;
	// private Node2D player3;
	// private Node2D player4;

	private AnimatedSprite2D dobbelSprite;

	private Random rnd = new Random();

	private List<Node2D> spaces = new List<Node2D>(); 

	private int player1CurrentSpace = 0; 

	int loc_pl1 = 0;
	int loc_pl2 = 0;
	int loc_pl3 = 0;
	int loc_pl4 = 0;

	int spacesAmount = 42;
	   	Player player1;
		Player player2;
		Player player3;
		Player player4;


	private bool isRolling = false;
  	Dice dobbel1 = new Dice(0,4);
	public override void _Ready()
	{	
		
	

		
		
		player1 = GetNode<Player>("player1");
		// player2 = GetNode<Player>("players/player2");
		// player3 = GetNode<Player>("players/player3");
		// player4 = GetNode<Player>("players/player4");

		dobbelSprite = GetNode<AnimatedSprite2D>("dobbelSprite");

	

		
		dobbelSprite.Play("0");
		
		for (int i = 1; i <= spacesAmount; i++)
		{
			spaces.Add(GetNode<Node2D>($"spaces/Marker2D{i}"));
		}
	}

	public override void _Process(double delta)
	{   
		if (Input.IsActionPressed("test1") && !isRolling)
		{

			isRolling = true;
			int diceRoll = dobbel1.diceroll();
            GD.Print("Dice roll is = " + diceRoll);
				for(int i = -3; i <= 9; i ++){
			// if(i == diceRoll){
			// 	dobbelSprite.Play($"{diceRoll}");
			// }
		}


			player1CurrentSpace = player1CurrentSpace + diceRoll;

			if (player1CurrentSpace < 0)
			{
				player1CurrentSpace = player1CurrentSpace = 0;
			}
			
			if (player1CurrentSpace >= spaces.Count) {
				player1CurrentSpace = player1CurrentSpace - spaces.Count;
			}
			// Move player to the next space
			Node2D nextSpace = spaces[player1CurrentSpace];
			 player1.Position= nextSpace.Position;
		}
		
		// if (Input.IsActionPressed("test2") && !isRolling)
		// {

		// 	isRolling = true;
		
			



		// 	player1CurrentSpace = player1CurrentSpace + diceRoll;

		// 	if (player1CurrentSpace < 0)
		// 	{
		// 		player1CurrentSpace = player1CurrentSpace = 0;
		// 	}
			
		// 	if (player1CurrentSpace >= spaces.Count) {
		// 		player1CurrentSpace = player1CurrentSpace - spaces.Count;
		// 	}
		// 	// Move player to the next space
		// 	Node2D nextSpace = spaces[player1CurrentSpace];
		// 	player1.Position = nextSpace.Position;
		// }

		// if (Input.IsActionPressed("test3") && !isRolling)
		// {

		// 	isRolling = true;
		// 	int diceRoll = level3Dice();



		// 	player1CurrentSpace = player1CurrentSpace + diceRoll;

		// 	if (player1CurrentSpace < 0)
		// 	{
		// 		player1CurrentSpace = player1CurrentSpace = 0;
		// 	}
			
		// 	if (player1CurrentSpace >= spaces.Count) {
		// 		player1CurrentSpace = player1CurrentSpace - spaces.Count;
		// 	}
		// 	// Move player to the next space
		// 	Node2D nextSpace = spaces[player1CurrentSpace];
		// 	player1.Position = nextSpace.Position;
		// }

		// if (Input.IsActionPressed("test4") && !isRolling)
		// {

		// 	isRolling = true;
		// 	int diceRoll = level4Dice();



		// 	player1CurrentSpace = player1CurrentSpace + diceRoll;

		// 	if (player1CurrentSpace < 0)
		// 	{
		// 		player1CurrentSpace = player1CurrentSpace = 0;
		// 	}
			
		// 	if (player1CurrentSpace >= spaces.Count) {
		// 		player1CurrentSpace = player1CurrentSpace - spaces.Count;
		// 	}
		// 	// Move player to the next space
		// 	Node2D nextSpace = spaces[player1CurrentSpace];
		// 	player1.Position = nextSpace.Position;
		// }

		if (Input.IsActionJustReleased("test1"))
		{
			isRolling = false;
		}
		
		if (Input.IsActionJustReleased("test2"))
		{
			isRolling = false;
		}

		if (Input.IsActionJustReleased("test3"))
		{
			isRolling = false;
		}

		if (Input.IsActionJustReleased("test4"))
		{
			isRolling = false;
		}
	}
 
	
}
