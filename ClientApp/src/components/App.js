import { BrowserRouter as Router,
  Switch,
  Route } from 'react-router-dom'
// import styled from 'styled-components'
import Header from './Header'
import About from './Main/About'
import Splash from './Splash'
import Main from './Main'
import Footer from './Footer'
import { getBackground } from '../img/backgrounds'
// import logo from './logo.svg'
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
    color: `#EDC9AF`,
    textShadow: `1px 1px 10px #EDC9AF`,
    fontSize: `.75em` }

  return (
    <Router>
      <div style={{ display: `flex`,
        flexDirection: `column`,
        backgroundImage: `url(${background})`,
        backgroundSize: `100%`,
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
            <div style={{
              display: `flex`,
              flexDirection: `column`,
              maxWidth: `45vw`,
              margin: `auto`,
              justifyContent: `center`,
              alignItems: `center`,
            }}
            >
              <Splash />
            </div>
          </Route>
          <Route path='/about'>
            <div style={{
              display: `flex`,
              flexDirection: `column`,
              maxWidth: `45vw`,
              margin: `auto`,
              padding: `10px`,
              alignItems: `center`,
              justifyContent: `center`,
              backgroundColor: `#0A090C`,
            }}
            >
              <About style={{ justifyContent: `center`,
                alignItems: `center` }}
              />
            </div>
          </Route>
          <Route path='/estimate'>
            <Main style={{ justifyContent: `center`,
              alignItems: `center` }}
            />
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
