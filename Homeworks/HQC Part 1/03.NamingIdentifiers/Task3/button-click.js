function buttonClick(event, arguments) {
  var currentWindow= window,
      browserType = currentWindow.navigator.appCodeName,
      isMozilla = browserType == "Mozilla";
  if (isMozilla) {
    alert("Yes");
  } else {
    alert("No");
  }
}