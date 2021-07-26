import { Link } from 'react-router-dom'

export default () => (
  <div>
    <h1>sqstr</h1>
    <Link exact to='/'>Home</Link>
    <Link to='/about'>About</Link>
    <Link to='/estimate'>Estimate</Link>
  </div>

)
