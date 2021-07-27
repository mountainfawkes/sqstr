import { BrowserRouter as Router,
  Switch,
  Route } from 'react-router-dom'
// import styled from 'styled-components'
import Header from './Header'
import About from './Main/About'
import Splash from './Splash'
import Main from './Main'
// import Footer from './Footer'
// import { getBackground } from '../img/backgrounds'
// import logo from './logo.svg'
// import './App.css'

function App() {
  // const background = getBackground()

  return (
    <Router>
      <div>
        <div>
          <Header />
        </div>

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

        {/* <div style={{ display: `block`,
          width: `100%`,
          zIndex: `100`,
          position: `fixed`,
          bottom: `0`,
          left: `0`,
          background: `#000000`,
          padding: `20px`,
          color: `#000000` }}
        >
          <Footer />
        </div> */}
      </div>
    </Router>
  )
}

export default App
