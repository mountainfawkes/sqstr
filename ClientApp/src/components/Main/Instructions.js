export default () => {
  const contentStyles = {
    maxWidth: `45vw`,
    margin: `auto`,
    marginTop: `30px`,
    padding: `10px`,
    justifyContent: `center`,
    alignItems: `center`,
    backgroundColor: `#0A090C`,
  }

  return (
    <div style={contentStyles}>
      <div style={{
        backgroundColor: `#131217`,
        color: `#D1C7CA`,
        padding: `15px`,
        fontSize: `.75em`,
        fontFamily: `'Montserrat', sans-serif`,
        fontStyle: `italic`,
        backdropFilter: `blur(30%)`,
      }}
      >
        <p>Use the toolbar to select a method.</p>
      </div>
    </div>

  )
}
