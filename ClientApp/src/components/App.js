import { BrowserRouter as Router,
  Switch,
  Route } from 'react-router-dom'
import Header from './Header'
import About from './Main/About'
import Splash from './Splash'
import Main from './Main'
import Footer from './Footer'
import { getBackground } from '../img/backgrounds'
// import './App.css'

function App() {
  const background = getBackground()

  const headerStyles = { display: `flex`,
    flexDirection: `column`,
    width: `100%`,
    zIndex: `100`,
    position: `fixed`,
    top: `0`,
    left: `0`,
    padding: `20px`,
    color: `#000000` }

  const footerStyles = { display: `flex`,
    width: `100%`,
    zIndex: `100`,
    position: `fixed`,
    bottom: `0`,
    left: `0`,
    margin: `0 0 0 20px`,
    padding: `20px`,
    color: `#D1C7CA`,
    fontSize: `.75em` }

  const contentStyles = {
    display: `flex`,
    flexDirection: `column`,
    maxWidth: `45vw`,
    margin: `auto`,
    justifyContent: `center`,
    alignItems: `center`,
  }

  return (
    <Router>
      <div style={{ display: `flex`,
        flexDirection: `column`,
        backgroundImage: `url(${background})`,
        backgroundSize: `cover`,
        backgroundRepeat: `no-repeat`,
        backgroundColor: `#020202`,
        minWidth: `100vw`,
        minHeight: `100vh`,
        position: `absolute`,
        top: `0`,
        left: `0`,
        zIndex: `-99` }}
      >
        <div style={headerStyles}>
          <Header />
        </div>

        <Switch>
          <Route exact path='/'>
            <div style={contentStyles}>
              <Splash />
            </div>
          </Route>
          <Route path='/about'>
            <div style={{ ...contentStyles,
              padding: `10px`,
              backgroundColor: `#0A090C` }}
            >
              <About />
            </div>
          </Route>
          <Route path='/estimate'>
            <Main />
          </Route>
        </Switch>

        <div style={footerStyles}>
          <Footer />
        </div>
      </div>
    </Router>
  )
}

export default App
