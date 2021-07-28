import { Link } from 'react-router-dom'

export default () => (
  <>
    <span style={{
      margin: `0px 20px 0px 20px`,
    }}
    >
      <Link
        exact
        to='/'
        style={{ fontFamily: `'Megrim', cursive`,
          fontSize: `3em`,
          color: `#EDC9AF`,
          textShadow: `1px 1px 10px #EDC9AF`,
          textDecoration: `none` }}
      >sqstr</Link>
    </span>
    <span style={{
      margin: `20px 0px 10px 20px`,
    }}
    >
      <Link
        to='/estimate'
        style={{ fontFamily: `'Playfair Display', serif`,
          fontSize: `1em`,
          color: `#EDC9AF`,
          textShadow: `1px 1px 10px #EDC9AF`,
          textDecoration: `none` }}
      >Estimate</Link>
    </span>
    <span style={{
      margin: `0px 0px 10px 20px`,
    }}
    >
      <Link
        to='/about'
        style={{ fontFamily: `'Playfair Display', serif`,
          fontSize: `1em`,
          color: `#EDC9AF`,
          textShadow: `1px 1px 10px #EDC9AF`,
          textDecoration: `none` }}
      >About</Link>
    </span>
  </>

)
