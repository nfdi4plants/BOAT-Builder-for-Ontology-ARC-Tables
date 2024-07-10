module Main

open Feliz
open Browser.Dom
open Fable.Core.JsInterop

importSideEffects "./styling.scss"


let root = ReactDOM.createRoot(document.getElementById "feliz-app")
root.render(App.View.Main())