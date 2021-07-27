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

  return (
    <Router>
      <div style={{ display: `flex`,
        flexDirection: `column`,
        backgroundImage: `url(${background})`,
        backgroundSize: `cover`,
        backgroundRepeat: `no-repeat`,
        minWidth: `110vw`,
        minHeight: `110vh`,
        position: `absolute`,
        top: `0`,
        left: `0` }}
      >
        <Header style={{ }} />

        <Switch>
          <Route exact path='/'>
            <Splash style={{
              justifyContent: `center`,
              alignItems: `center`,
            }}
            />
          </Route>
          <Route path='/about'>
            <About style={{ justifyContent: `center`,
              alignItems: `center` }}
            />
          </Route>
          <Route path='/estimate'>
            <Main style={{ justifyContent: `center`,
              alignItems: `center` }}
            />
          </Route>
        </Switch>

        <Footer />
      </div>
    </Router>
  )
}

export default App
