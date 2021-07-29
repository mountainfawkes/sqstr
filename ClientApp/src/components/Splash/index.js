// import Auth from './Auth'
import Elevator from './Elevator'

export default () => (
  <>
    <div
      style={{
        display: `flex`,
        order: `0`,
        padding: `10px`,
        justifyContent: `center`,
        alignItems: `center`,
        color: `#F5F5F5`,
        borderRadius: `15px`,
        zIndex: `100`,
        textAlign: `center`,
        textShadow: `3px 3px 7px #0A090C`,
      }}
    >
      <Elevator />
    </div>
    {/* <div style={{
      display: `flex`,
      order: `1`,
      justifyContent: `center`,
      alignItems: `center`,
    }}
    >
      <Auth />
    </div> */}
  </>
)
