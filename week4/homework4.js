function changeChooser() {
	var chooser = document.getElementById("animalChooser");
	var options = chooser.options;
	var counter = 0;
	
	while (counter < options.length) {
		if (options[counter].selected) {
			document.getElementById(options[counter].value).style.display = "";
		} else {
			document.getElementById(options[counter].value).style.display = "none";
		}
		counter++;
	}
}

function monkeyFunction() {
	var monkeyText;
	var monkeyFruits = document.getElementById("monkeyInput").value;
	
	switch(monkeyFruits) {
		case "banana":
			monkeyText = "Martin would love a banana!";
		break;
		case "bamboo":
			monkeyText = "Martin can't chew through a bamboo.";
		break;
		case "acorn":
			monkeyText = "Martin does not like acorns.";
		break;
		default:
			monkeyText = "hmmm... I don't know if he wants to eat that?";
	}
	document.getElementById("monkeyOpinion").innerHTML = monkeyText;
}

function pandaFunction() {
	var pandaText;
	var pandaFruits = document.getElementById("pandaInput").value;
	
	switch(pandaFruits) {
		case "banana":
			pandaText = "Pinky thinks bananas smell weird.";
		break;
		case "bamboo":
			pandaText = "Pinky loves some bamboo!";
		break;
		case "acorn":
			pandaText = "Acorns are too small for Pinky...";
		break;
		default:
			pandaText = "hmmm... I don't know if he wants to eat that?";
	}
	document.getElementById("pandaOpinion").innerHTML = pandaText;
}

function squirrelFunction() {
	var squirrelText;
	var squirrelFruits = document.getElementById("squirrelInput").value;
	
	switch(squirrelFruits) {
		case "banana":
			squirrelText = "Sylvia thinks bananas are too mushy.";
		break;
		case "bamboo":
			squirrelText = "Sylvia would rather want to climb bamboo.";
		break;
		case "acorn":
			squirrelText = "Sylvia loves to eat acorns!";
		break;
		default:
			squirrelText = "hmmm... I don't know if she wants to eat that?";
	}
	document.getElementById("squirrelOpinion").innerHTML = squirrelText;
}
