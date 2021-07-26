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
    <div style={{ backgroundImage: `url(${background})`,
      backgroundSize: `cover`,
      backgroundRepeat: `no-repeat`,
      width: `100%` }}
    >

      <Header />
      <Splash />
      <About />
      <Main />
      <Footer />
    </div>
  )
}

export default App
