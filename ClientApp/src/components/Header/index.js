import { Link } from 'react-router-dom'

export default () => (
  <>
    <span>sqstr</span>
    <span>
      <Link exact to='/'>Home</Link>
    </span>
    <span>
      <Link to='/about'>About</Link>
    </span>
    <span>
      <Link to='/estimate'>Estimate</Link>
    </span>
  </>

)
