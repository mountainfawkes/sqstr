import { BrowserRouter as Router,
  Switch,
  Route } from 'react-router-dom'
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
      <div style={{ backgroundImage: `url(${background})`,
        backgroundSize: `cover`,
        backgroundRepeat: `no-repeat`,
        width: `100%` }}
      >

        <Header />

        <Switch>
          <Route exact path='/'>
            <Splash />
          </Route>
          <Route path='/about'>
            <About />
          </Route>
          <Route path='/estimate'>
            <Main />
          </Route>
        </Switch>

        <Footer />
      </div>
    </Router>
  )
}

export default App
