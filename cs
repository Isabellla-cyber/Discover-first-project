body { container: system-ui;
background-color:orange; 
color:blue;
  text-align: center;
height:800px;
width:900px;
margin:auto;
} 
div{
  img{  filter: contrast(2000000%);
  }
  * {
  margin: 0;
  padding: 0;
    box-sizing: border-box;
}

body {
  text-align:
  margin:
  font-family: 'Roboto';
}

{
  margin:;
  padding-top: ;
  clear:both;
}

img {
  max-width:;
  margin: ;
  padding:;
}

img:nth-of-type(1) {
  filter: brightness(2000000%);
}

img:nth-of-type(1) {
  filter: brightness(2000000%);
}

    url(
"https://cdn.pixabay.com/photo/2017/03/23/09/34/artificial-intelligence-2167835_960_720.jpg" height="590">)
  backgroung repeat:no-repeat;
  background-color:orange;
  align:;
}
body{
  margin:;
  padding:;
  color:#;
  font-family:Arial Narrow;
}

$grey: #ccc;
$muted-grey: #999;
$heart: #ff4f8f;
$white: #fff;

.like-button {
    position: relative;
    width: 50px;
    height: 50px;
    border-radius: 50%;
    background: $grey;
    display: flex;
    justify-content: center;
    align-items:center;
    margin: 0 auto;
    text-decoration: none;
    overflow: hidden;
}

.like-button {
    .like-overlay {
        display: block;
        position: absolute;
        top: 0;
        left: 0;
        width: 50px;
        height: 50px;
        border-radius: 50%;
        background: $heart;
        transform: scale(0);
        transition: all .4s;
        z-index: 0;
    }
}
.like-button { 
  {       
     &.is-liked {
          display: none;
          color: $red;
          position: relative;
          z-index: 1;
        }
    }
}
//Defining the animation
@-webkit-keyframes bouncy {
    from, to { -webkit-transform: scale(1, 1); }
    25% { -webkit-transform: scale(0.9, 1.1); }
    50% { -webkit-transform: scale(1.1, 0.9); }
    75% { -webkit-transform: scale(0.95, 1.05); }
}
@keyframes bouncy {
    from, to { transform: scale(1, 1); }
    25% { transform: scale(0.9, 1.1); }
    50% { transform: scale(1.1, 0.9); }
    75% { transform: scale(0.95, 1.05); }
}

//Animation Settings
.bouncy {
    -webkit-animation: bouncy 0.6s;
    animation: bouncy 0.6s;
    -webkit-animation-duration: 0.6s;
    animation-duration: 0.6s;
    -webkit-animation-fill-mode: both;
    animation-fill-mode: both;
}
.like-button {
    &.is-active {
        .like-overlay {
            transform: scale(1);
        }
       
            }
            &.is-liked {
                display: block;
            }
        }
    }
}



* {box-sizing: border-box;}
html, body {height:100%;}
body { 
  background:#212121;
  background-image: url("https://images.unsplash.com/photo-1547132025-0868fd15d909?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9
  background-size: cover;
  padding: 0 16px;
	// top:0!important; // Prevent Google Topbar from pushing down body.
  h1 {color:#fff; margin: 1em 0 0.5em 0; letter-spacing: -1px;}
	h2 {color:#fff; margin: 0 0 1em 0; font-weight:100;font-size: 1.8em; letter-spacing: -1px;}
  p {color:#fff;}
  a {color:#fff;}
}
// .goog-te-banner-frame {display:none;} // Don't show Google Topbar
// #goog-gt-tt {display:none!important;visibility:hidden!important;}

#google_translate_element {
  position: absolute;
  bottom: calc(53px + 16px);
  right: 16px!important;
  // z-index: 99999;
}
.goog-te-gadget {
  font-family: Roboto, 'Open Sans', sans-serif!important;
  text-transform: uppercase;
}
.goog-te-gadget-simple  {
  background-color: rgba(255,255,255,0.20)!important;
  border: 1px solid rgba(255,255,255,0.50) !important;
  padding: 8px!important;
  border-radius: 4px!important;
  font-size: 1rem!important;
  line-height:2rem!important;
  display: inline-block;
  cursor: pointer;
  zoom: 1;
}
.goog-te-menu2 {
  max-width: 100%;
}
.goog-te-menu-value {
  color: #fff !important;
    &:before {
    font-family: 'Material Icons';
    content: "\E927";
    margin-right: 16px;
    font-size: 2rem;
    vertical-align: -10px;
    // width:32px!important;
  } 
}
.goog-te-menu-value span:nth-child(5) {
  display:none;
}
.goog-te-menu-value span:nth-child(3) {
  border:none!important;
  font-family: 'Material Icons';
  &:after {
    font-family: 'Material Icons';
    content: "\E5C5";
    font-size: 1.5rem;
    vertical-align: -6px;
  }  
}

.goog-te-gadget-icon {
    background-image: url(https://placehold.it/32)!important;
    background-position: 0px 0px;
    height: 32px!important;
    width: 32px!important;
    margin-right: 8px!important;
    //     OR
    display: none;
}

// ============ HIDE TOP BAR ============ 
.goog-te-banner-frame.skiptranslate {display: none!important;} 
body {top: 0px!important;}

/* ================================== *\
    Mediaqueries
\* ================================== */
@media (max-width: 667px) {
	#google_translate_element {
		bottom: calc(100% - 50% - 53px);
		left: 16px!important;
		width: 100%!important;
		goog-te-gadget {
			width:100%!important;
		}
		.skiptranslate {
			width:100%!important;			
		}
		.goog-te-gadget-simple {
			width: calc(100% - 32px)!important;
			text-align: center;
		}	
	}
}



