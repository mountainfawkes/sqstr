/* eslint-disable jsx-a11y/click-events-have-key-events */
export default ({ mainCallback }) => {
  const buttonStyle = { fontWeight: `bold`,
    fontSize: `1.5em`,
    margin: `5px`,
    padding: `10px`,
    borderRadius: `15px`,
    borderStyle: `none`,
    backgroundColor: `#131217`,
    color: `#F0EDEE` }

  return (
    <div
      style={{ display: `flex`,
        flexFlow: `flex wrap`,
        borderRadius: `15px`,
        width: `auto`,
        height: `auto`,
        margin: `auto`,
        textAlign: `center`,
        backgroundColor: `#0A090C` }}
    >
      {/* <span>Estimates</span> */}
      <span
        onClick={() => mainCallback(0)}
        role='button'
        tabIndex={0}
        style={{ ...buttonStyle, order: `0` }}
      >Electricity</span>
      <span
        onClick={() => mainCallback(1)}
        role='button'
        tabIndex={0}
        style={{ ...buttonStyle, order: `1` }}
      >Flight</span>
      <span
        onClick={() => mainCallback(2)}
        role='button'
        tabIndex={0}
        style={{ ...buttonStyle, order: `2` }}
      >Shipping</span>
      <span
        onClick={() => mainCallback(3)}
        role='button'
        tabIndex={0}
        style={{ ...buttonStyle, order: `3` }}
      >Vehicle</span>
      <span
        onClick={() => mainCallback(4)}
        role='button'
        tabIndex={0}
        style={{ ...buttonStyle, order: `4` }}
      >Fuel Combustion</span>
    </div>
  )
}
