function solve() {
  return function (element, contents) {
    var el = null;    
    if (element instanceof HTMLElement) {
      el = element;
    } else if (typeof element === 'string') {
      el = document.getElementById(element);
    }
    if (!el || !element || !contents || !(contents instanceof Array)) {
      throw new Error();
    }        
    var docFrag = document.createDocumentFragment();
    var div = document.createElement('div');
    for(var i = 0, len = contents.length; i < len; i += 1) {
      var currentDiv = div.cloneNode(true);
      if (typeof contents[i] !== 'string' && typeof contents[i] !== 'number')  {
        throw new Error();
      }
      currentDiv.innerHTML = contents[i];
      docFrag.appendChild(currentDiv);
    }
    el.innerHTML = '';
    el.appendChild(docFrag);
  };
}