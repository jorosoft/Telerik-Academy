function solve(){
  return function (selector) {
    var element = null;
    if (selector instanceof HTMLElement) {
      element = selector;
    } else if (typeof selector === 'string') {
      element = document.getElementById(selector);
    } else {
      throw new Error();
    }
    if (!element) {
      throw new Error();
    }
    var buttonElements = element.getElementsByClassName('button');
    for(var i = 0; i < buttonElements.length; i += 1) {
      buttonElements[i].innerHTML = 'hide';
    }
    var root = document.getElementById('root');
    root.addEventListener('click', function (ev) {
      var clickedBtn = ev.target;
      var nextElement = clickedBtn.nextElementSibling;
      var nextNextElement = nextElement.nextElementSibling;
      if (nextElement.className === 'content' && nextNextElement.className === 'button') {
        if (nextElement.style.display === 'none') {
          nextElement.style.display = '';
          clickedBtn.innerHTML = 'hide';
        } else {
          nextElement.style.display = 'none';
          clickedBtn.innerHTML = 'show';
        }
      }    
    }, false);
  };
}