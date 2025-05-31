function changeImg(){
  element=document.getElementById("img1")
    if(element.src.match("pic_bulbon.gif")){
      element.src="pic_bulboff.gif";
    }
    else{
      element.src="pic_bulbon.gif"
    }
  }
