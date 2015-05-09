//linear//radial
function bubblesMain(obj){
	bubbleResize();
	bubbles = new bubbleObject(obj);
	bubbles.createBubbles();
	setInterval(start,1000/60);
};

//WHEN WINDOW HEIGHT IS CHANGED, REMAKE THE CANVAS ELEMENT
window.onresize = function(event) {
	bubbleResize();
}


function bubbleResize(){
	var height = parseInt(document.getElementById("canvasBubbles").clientHeight);
	var width = parseInt(document.getElementById("canvasBubbles").clientWidth);
	document.getElementById("canvasBubbles").innerHTML = '<canvas id="canvas" width="'+width+'px" height="'+height+'px"></canvas>';
}

function start(){
	
	var canvas = document.getElementById("canvas");
	canvas.width = canvas.width;
	bubbles.move();
	bubbles.draw();
};

function bubbleObject(options){
	(options.type) ? this.type = options.type : this.type = "linear";
	if(this.type == "radial"){
		(options.revolve) ? this.revolve = options.revolve : this.revolve = "";
	}
	(options.opacity) ? this.opacity = options.opacity : this.opacity = .1;
	(options.colors) ? this.colors = options.colors : this.colors = new Array("#DDDDDD");
	
	(options.minSize) ? this.minSize = options.minSize : this.minSize = 20;
	(options.maxSize) ? this.maxSize = options.maxSize : this.maxSize = 100;
	
	//THIS WAS SUPPOSED TO BE FOR CHANGING COLORS
	/*if(options.changeColors){
		for(var i = 0;i<options.changeColors.length;i++){
			options.changeColors[i] = getRGB(options.changeColors[i]);
		}
		this.changeColors = options.changeColors;
	}else{
		this.changeColors = 0;
	}
*/
	(options.num) ? this.num = parseInt(options.num) : this.num = 100;
	(options.maxSpeed) ? this.maxSpeed = parseInt(options.maxSpeed) : this.maxSpeed = 10;
	(options.minSpeed) ? this.minSpeed = parseInt(options.minSpeed) : this.minSpeed = 1;
	
	this.createBubbles = function(){
		this.bubbles = new Array();
			if(this.type == "radial"){
				var x = 0;
				var y =  0;
				var minRad = 250;
				for(var i = 0;i<this.num;i++){
					var size = Math.floor(Math.random()*(this.maxSize-this.minSize+1)+this.minSize);
					var speed = Math.floor(Math.random()*(this.maxSpeed-this.minSpeed+1)+this.minSpeed);
					speed /= 3000;
					
					if(Math.floor(Math.random() * 2) == 1){
						speed *= -1;
					}
					
					if(this.colors){
						var rand = Math.floor(Math.random() * this.colors.length);
						
						var color = getRGB(this.colors[rand]);
						
						var colorType = rand;
					}else{
						var color = '';
						var colorType = '';
					}
					
	
					var radius =  Math.floor(Math.random()*((window.innerWidth+200)-minRad+1)+minRad);
					//var degree =  Math.floor(Math.random()*(330-140+1)+140);
					var degree =  Math.floor(Math.random()*(360-0+1)+0);
					this.bubbles.push(new Object({
						"x" : x,
						"y" : y,
						"degree" : degree,
						"radius" : radius,
						"speed" : speed,
						"size" : size,
						"color" : color,
						"colorType" : colorType
					}));
				}
			}else if(this.type == "linear"){
				for(var i = 0;i<this.num;i++){
					var size = Math.floor(Math.random()*(this.maxSize-this.minSize+1)+this.minSize);
					var x = Math.floor(Math.random()*(window.innerWidth-0+1)+0);
					var y = Math.floor(Math.random()*(window.innerHeight-0+1)+0);
					var xVel = (Math.floor(Math.random()*(this.maxSpeed-this.minSpeed+1)+this.minSpeed))/10;
					if(Math.floor(Math.random() * 2) == 1){
						xVel *= -1;
					}
					var yVel = (Math.floor(Math.random()*(this.maxSpeed-this.minSpeed+1)+this.minSpeed))/10;
					if(Math.floor(Math.random() * 2) == 1){
						yVel *= -1;
					}
					
					
					xVel /= 10;
					yVel /= 10;
					
					if(this.colors){
						var rand = Math.floor(Math.random() * this.colors.length);
						var color = getRGB(this.colors[rand]);
						var colorType = rand;
					}else{
						var color = '';
						var colorType = '';
					}
				
					
					this.bubbles.push(new Object({
						"x" : x,
						"y" : y,
						"xVel" : xVel,
						"yVel" : yVel,
						"size" : size,
						"color" : color,
						"colorType" :colorType
					}));
				}
				
			}
		
	}
	
	//FOR COLOR CHANGING
	function getRGB(hex){
		var result = /^#?([a-f\d]{2})([a-f\d]{2})([a-f\d]{2})$/i.exec(hex);
		return result ? {
			r: parseInt(result[1], 16),
			g: parseInt(result[2], 16),
			b: parseInt(result[3], 16)
		} : null;
	}

	
	this.move = function(){
		var len = this.bubbles.length;
		if(this.type == "radial"){
		
			switch(this.revolve){
				case 'bottomLeft' :
							var arcMiddleX = 0;
							var arcMiddleY = window.innerHeight;
					break;
				case 'topLeft' :
							var arcMiddleX = 0;
							var arcMiddleY = 0;
					break;
				case 'topRight' :
							var arcMiddleX = window.innerWidth;
							var arcMiddleY = 0;
					break;
				case 'center' :
							var arcMiddleX = window.innerWidth / 2;
							var arcMiddleY = window.innerHeight / 2;
					break;
				default : 	var arcMiddleX = window.innerWidth;
							var arcMiddleY = window.innerHeight;
			}
			
			
			for(var i = 0;i<len;i++){
				var radians = this.bubbles[i].degree * (Math.PI / 180);  
				this.bubbles[i].x = arcMiddleX + this.bubbles[i].radius * Math.cos(radians)
				this.bubbles[i].y = arcMiddleY + this.bubbles[i].radius * Math.sin(radians)
				this.bubbles[i].degree+= this.bubbles[i].speed;
				
				if(this.bubbles[i].degree > 360){
					this.bubbles[i].degree = this.bubbles[i].degree - 360;
				}else if(this.bubbles[i].degree < 0){
					this.bubbles[i].degree = 360 - this.bubbles[i].degree;
				}
				
				
				
				//COLOR CHANGING
				/*if(this.changeColors != 0){
					var num = (Math.floor(Math.random()*(3-1+1)+1));
					
					
					var goToColor = this.changeColors[this.bubbles[i].colorType];
					
					
					
					
					var fastChanging = 1;
					
					switch(num){
						case 1 : 
							if(goToColor.r > this.bubbles[i].color.r){
								this.bubbles[i].color.r+=fastChanging;
							}else if(goToColor.r < this.bubbles[i].color.r){
								this.bubbles[i].color.r-=fastChanging;
							}
							break;
						case 2 : 
							if(goToColor.g > this.bubbles[i].color.g){
								this.bubbles[i].color.g+=fastChanging;
							}else if(goToColor.g < this.bubbles[i].color.g){
								this.bubbles[i].color.g-=fastChanging;
							}
							break;
						case 3 : 
							if(goToColor.b > this.bubbles[i].color.b){
								this.bubbles[i].color.b+=fastChanging;
							}else if(goToColor.b < this.bubbles[i].color.b){
								this.bubbles[i].color.b-=fastChanging;
							}
							break;
					}
					
					
					
				}*/
				
				/*if(this.revolve != "center"){
					//RESET
					
					if(this.bubbles[i].degree >= maxDeg && this.bubbles[i].speed > 0){
						this.bubbles[i].degree = minDeg;
					}
					
					//RESET
					if(this.bubbles[i].degreen <= minDeg && this.bubbles[i].speed < 0){
						this.bubbles[i].degree = maxDeg;
					}
				}*/
			}
		
		}else if(this.type =="linear"){
			for(var i = 0;i<len;i++){
				this.bubbles[i].x += this.bubbles[i].xVel;
				this.bubbles[i].y += this.bubbles[i].yVel;
				
				/*
				//CHANGE COLORS
				if(this.changeColors != 0){
					var num = (Math.floor(Math.random()*(3-1+1)+1));
					
					
						//NORMAL GOTO
						var goToColor = this.changeColors[this.bubbles[i].colorType];
					
					
					var fastChanging = 1;
					
					switch(num){
						case 1 : 
							if(goToColor.r > this.bubbles[i].color.r){
								this.bubbles[i].color.r+=fastChanging;
							}else if(goToColor.r < this.bubbles[i].color.r){
								this.bubbles[i].color.r-=fastChanging;
							}
							break;
						case 2 : 
							if(goToColor.g > this.bubbles[i].color.g){
								this.bubbles[i].color.g+=fastChanging;
							}else if(goToColor.g < this.bubbles[i].color.g){
								this.bubbles[i].color.g-=fastChanging;
							}
							break;
						case 3 : 
							if(goToColor.b > this.bubbles[i].color.b){
								this.bubbles[i].color.b+=fastChanging;
							}else if(goToColor.b < this.bubbles[i].color.b){
								this.bubbles[i].color.b-=fastChanging;
							}
							break;
					}
					
					
				}
				*/
				var width = window.innerWidth;
				var height = window.innerHeight;
				
				//RESET
				if(this.bubbles[i].y < (0 - this.bubbles[i].size) && this.bubbles[i].yVel < 0){
					//RESET Y-;
					this.bubbles[i].y = height;
				}else if(this.bubbles[i].y > (height + this.bubbles[i].size) && this.bubbles[i].yVel > 0){
					//RESET Y+
					this.bubbles[i].y = 0 - this.bubbles[i].size;
				}else if(this.bubbles[i].x < (0 - this.bubbles[i].size) && this.bubbles[i].xVel < 0){
					//RESET X+
					this.bubbles[i].x = width;
				}else if(this.bubbles[i].x > (width + this.bubbles[i].size) && this.bubbles[i].xVel > 0){
					//RESET X-;
					this.bubbles[i].x = 0 - this.bubbles[i].size;
				}
				
				
			}
		}
	}
	
	this.draw = function(){
		var canvas = document.getElementById("canvas");
		var ctx = canvas.getContext("2d");
		var len = this.bubbles.length;
		if(this.type == "radial"){
			for(var i = 0;i<len;i++){
				ctx.beginPath();  
				//GIVE BUBBLES GRADIENT, TOO SLOW IN FF?
				//var radgrad = ctx.createRadialGradient(this.bubbles[i].x, this.bubbles[i].y,0,this.bubbles[i].x, this.bubbles[i].y,this.bubbles[i].size);
				//radgrad.addColorStop(0, 'rgba(255,255,255,.1)');
				//radgrad.addColorStop(0.8, 'rgba(255,255,255,.1)');
				//radgrad.addColorStop(1, 'rgba(255,255,255,0)');
				//ctx.fillStyle = radgrad;
				
				ctx.fillStyle = "rgba("+this.bubbles[i].color.r+","+this.bubbles[i].color.g+","+this.bubbles[i].color.b+","+this.opacity+")";
				
				ctx.arc(this.bubbles[i].x, this.bubbles[i].y, this.bubbles[i].size, 0, Math.PI*2, false);  
				ctx.fill();  
				ctx.closePath();  
				
			}
		}else if(this.type =="linear"){
			for(var i = 0;i<len;i++){
				ctx.beginPath();
				
				ctx.fillStyle = "rgba("+this.bubbles[i].color.r+","+this.bubbles[i].color.g+","+this.bubbles[i].color.b+","+this.opacity+")";
				
				ctx.arc(this.bubbles[i].x, this.bubbles[i].y, this.bubbles[i].size, 0, Math.PI*2, false);  
				ctx.fill();  
				ctx.closePath();  
			}
		}
		
	}
};